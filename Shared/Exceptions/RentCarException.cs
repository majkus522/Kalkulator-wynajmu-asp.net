namespace Shared.Exceptions;

public abstract class RentCarException : Exception
{
    protected RentCarException(string message) : base(message) { }
}