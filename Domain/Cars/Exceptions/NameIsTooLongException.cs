using Shared.Exceptions;

namespace Domain.Cars.Exceptions;

public class NameIsTooLongException : RentCarException
{
    public string Property { get; set; }
    public NameIsTooLongException(string property) : base($"{property} is too long")
    {
        Property = property;
    }
}