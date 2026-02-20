namespace TaskManagement.Exceptions;

internal class ConflictException : Exception
{
    public ConflictException() : base("Conflict occurred while processing the request.")
    {
    }

    public ConflictException(string message) : base(message)
    {
    }
}
