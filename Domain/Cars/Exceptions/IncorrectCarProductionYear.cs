using Shared.Exceptions;

namespace Domain.Cars.Exceptions;

public class IncorrectCarProductionYear : RentCarException
{
    public IncorrectCarProductionYear() : base("Incorrect year of production entered")
    {
    }
}