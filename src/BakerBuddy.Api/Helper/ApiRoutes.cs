namespace BakerBuddy.Api.Helper;

#pragma warning disable CA1034
#pragma warning disable CA1724
public static class ApiRoutes
{
    public const string Base = "api";

    public static class Ingredient
    {
        public const string Post = Base + "/ingredient";
        public const string Get = Base + "/ingredient/{id}";
        public const string Put = Base + "/ingredient/{id}";
        public const string Delete = Base + "/ingredient/{id}";
    }

    public static class Recipe
    {
        public const string Post = Base + "/recipe";
        public const string Get = Base + "/recipe/{id}";
        public const string Put = Base + "/recipe/{id}";
        public const string Delete = Base + "/recipe/{id}";

        public static class Ingredient
        {
            public const string GetAll = Base + "/recipe/{id}/ingredient";
        }
    }

    public static class User
    {
        public static class Recipe
        {
            public const string GetAll = Base + "/user/{id}/recipe";
        }

        public static class Register
        {
            public const string Post = Base + "/user/register";
        }
    }
}
#pragma warning restore CA1034
#pragma warning restore CA1724