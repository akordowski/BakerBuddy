namespace BakerBuddy.Api.Helper;

public static class ApiRoutes
{
    public const string Base = "api";

    public static class User
    {
        public static class Register
        {
            public const string Post = Base + "/user/register";
        }
    }
}