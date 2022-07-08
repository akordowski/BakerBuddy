using AutoMapper;
using BakerBuddy.Data;
using BakerBuddy.Data.Entities;
using BakerBuddy.Domain.Commands.User;
using BakerBuddy.Domain.Dto;
using BakerBuddy.Domain.Exceptions;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace BakerBuddy.Application.Handler.Commands.User;

public class RegisterUserCommandHandler : CommandHandler<RegisterUserCommand>
{
    private readonly IBakerBuddyDbContext _dbContext;
    private readonly IMapper _mapper;
    private readonly ILogger _logger;

    public RegisterUserCommandHandler(
        IBakerBuddyDbContext dbContext,
        IMapper mapper,
        ILogger logger)
    {
        _dbContext = dbContext;
        _mapper = mapper;
        _logger = logger;
    }

    public override async Task Handle(
        RegisterUserCommand request,
        CancellationToken cancellationToken)
    {
        if (request is null)
        {
            throw new ArgumentNullException(nameof(request));
        }

        await CheckIfUserExistsAsync(request.UserData, cancellationToken).ConfigureAwait(false);
        await RegisterUserAsync(request.UserData, cancellationToken).ConfigureAwait(false);
    }

    private async Task CheckIfUserExistsAsync(
        UserDataDto userData,
        CancellationToken cancellationToken)
    {
        _logger.Information("Check if user with the username '{username}' exists.", userData.UserName);

        var userExists = await _dbContext.User
            .Where(e => e.UserName == userData.UserName)
            .AnyAsync(cancellationToken)
            .ConfigureAwait(false);

        if (userExists)
        {
            throw new UserFoundException($"User with the username '{userData.UserName}' already exists.");
        }
    }

    private async Task RegisterUserAsync(
        UserDataDto userData,
        CancellationToken cancellationToken)
    {
        var userEntity = _mapper.Map<UserEntity>(userData);

        _logger.Information("Register new user with the username '{username}'.", userEntity.UserName);

        await _dbContext.User.AddAsync(userEntity, cancellationToken).ConfigureAwait(false);
        await _dbContext.SaveChangesAsync(cancellationToken).ConfigureAwait(false);

        _logger
            .ForContext(nameof(userEntity.UserId), userEntity.UserId)
            .Information("User with the username '{username}' registered.", userEntity.UserName);
    }
}