using Domain.Cars.Exceptions;
using Shared.ValueObjects;

namespace Domain.Cars.ValueObjects.Categories;

public class Category : ValueObject
{
    public string Code { get; }

    private Category() {}

    public Category(string code)
    {
        var codeSupported = IsCodeSupported(code);
        if (!codeSupported)
            throw new UnsupportedCategoryException(code);
        Code = code;
    }

    private static bool IsCodeSupported(string code)
        => AvailableCategoriesCodes.AllCodes.Contains(code, StringComparer.InvariantCultureIgnoreCase);
    
    internal static Category Create(string code)
        => new(code);

    public override bool Equals(object obj)
    {
        return obj is Category make && Code == make.Code;
    }  
}