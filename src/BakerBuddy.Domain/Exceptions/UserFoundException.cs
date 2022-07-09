namespace BakerBuddy.Domain.Exceptions;

public class UserFoundException : Exception
{
    public UserFoundException()
    {
    }

    public UserFoundException(string message)
        : base(message)
    {
    }

    public UserFoundException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}