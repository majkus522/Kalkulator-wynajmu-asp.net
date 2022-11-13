namespace Domain.Cars.ValueObjects.Categories;

public static class AvailableCategoriesCodes
{
    public static readonly string SUV = nameof(SUV);
    public static readonly string Sedan = nameof(Sedan);
    public static readonly string Coupe = nameof(Coupe);
    public static readonly string Convertible = nameof(Convertible);
    public static readonly string Hatchback = nameof(Hatchback);
    public static readonly string Pickup = nameof(Pickup);
    public static readonly string Van = nameof(Van);
    public static readonly string Minivan = nameof(Minivan);
    public static readonly string Wagon = nameof(Wagon);

    internal static readonly IReadOnlyCollection<string> AllCodes = new List<string>
    {
        SUV,
        Sedan,
        Coupe,
        Convertible,
        Hatchback,
        Pickup,
        Van,
        Minivan,
        Wagon
    };
}