namespace Domain.Cars.ValueObjects.Categories;

internal static class AvailableCategories
{
    internal static readonly Category SUV = Category.Create(nameof(SUV));
    internal static readonly Category Sedan = Category.Create(nameof(Sedan));
    internal static readonly Category Coupe = Category.Create(nameof(Coupe));
    internal static readonly Category Convertible = Category.Create(nameof(Convertible));
    internal static readonly Category Hatchback = Category.Create(nameof(Hatchback));
    internal static readonly Category Pickup = Category.Create(nameof(Pickup));
    internal static readonly Category Van = Category.Create(nameof(Van));
    internal static readonly Category Minivan = Category.Create(nameof(Minivan));
    internal static readonly Category Wagon = Category.Create(nameof(Wagon));

    public static readonly HashSet<Category> All = new()
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