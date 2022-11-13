using Shared.Exceptions;

namespace Domain.Cars.Exceptions;

public class UnsupportedCategoryException : RentCarException
{
    public string Code { get; }

    public UnsupportedCategoryException(string code) : base($"An Category with this code: '{code}' is not supported.")
    {
        Code = code;
    }
}