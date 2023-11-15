namespace Task.Exceptions;

public class IncorrectPasswordException : Exception
{
    public IncorrectPasswordException(string message) : base(message)
    {

    }
}