using Shared.Exceptions;

namespace Domain.Cars.Exceptions;

public class UnsupportedMakeException : RentCarException
{
    public string Code { get; }

    public UnsupportedMakeException(string code) : base($"An Make with this code: '{code}' is not supported.")
    {
        Code = code;
    }
}