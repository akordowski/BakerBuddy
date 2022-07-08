using BakerBuddy.Api.Extensions;
using BakerBuddy.Api.Options;
using BakerBuddy.Application.Handler.Commands.User;
using BakerBuddy.Application.Mappings.Profiles;
using BakerBuddy.Application.Validators;
using BakerBuddy.Data;
using BakerBuddy.Domain.Commands.Users;
using BakerBuddy.Domain.Exceptions;
using FluentValidation.AspNetCore;
using Hellang.Middleware.ProblemDetails;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Serilog;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
var environment = builder.Environment;
var services = builder.Services;

var connectionString = configuration.GetConnectionString("Database");
var databaseOptions = configuration.GetOptions<DatabaseOptions>(DatabaseOptions.Section);

builder.Host.UseSerilog((context, config) => config.ReadFrom.Configuration(context.Configuration));

// Add services to the container.
services.AddAutoMapper(typeof(UserEntityProfile));
services.AddMediatR(typeof(RegisterUserCommand), typeof(RegisterUserCommandHandler));
services.AddFluentValidation(config => config.RegisterValidatorsFromAssemblyContaining<UserDataDtoValidator>());

services.AddDbContext<BakerBuddyDbContext>(options =>
{
    options.UseSqlite(connectionString, optionsBuilder => optionsBuilder.CommandTimeout(databaseOptions.CommandTimeoutInSeconds));
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
    options.EnableDetailedErrors(databaseOptions.EnableDetailedErrors);
    options.EnableSensitiveDataLogging(databaseOptions.EnableSensitiveDataLogging);
    options.ConfigureWarnings(w => w.Throw(RelationalEventId.MultipleCollectionIncludeWarning));
});

services.AddProblemDetails(options =>
{
    options.IncludeExceptionDetails = (_, _) => environment.IsDevelopment();
    options.MapToStatusCode<UserFoundException>(StatusCodes.Status400BadRequest);
    options.MapToStatusCode<NotImplementedException>(StatusCodes.Status501NotImplemented);
    options.MapToStatusCode<Exception>(StatusCodes.Status500InternalServerError);
});

services.AddControllers();

services.AddScoped<IBakerBuddyDbContext>(provider =>
{
    var dbContext = provider.GetRequiredService<BakerBuddyDbContext>();
    dbContext.Database.EnsureCreated();

    return dbContext;
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
services.AddEndpointsApiExplorer();
services.AddSwaggerGen(options =>
{
    options.EnableAnnotations();
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Serilog
if (configuration.GetValue<bool>("UseSerilogRequestLogging"))
{
    app.UseSerilogRequestLogging();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();