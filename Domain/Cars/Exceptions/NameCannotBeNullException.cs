using Shared.Exceptions;

namespace Domain.Cars.Exceptions;

public class NameCannotBeNullException : RentCarException
{
    public string Property { get; set; }
    public NameCannotBeNullException(string property) : base($"{property} can not be null")
    {
        Property = property;
    }
}