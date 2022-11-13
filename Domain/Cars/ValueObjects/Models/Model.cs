using Domain.Cars.Exceptions;
using Domain.Cars.ValueObjects.Categories;
using Domain.Cars.ValueObjects.Makes;
using Shared.ValueObjects;

namespace Domain.Cars.ValueObjects.Models;

public class Model : ValueObject
{
    public string Code { get; }
    public string Name { get;}
    public short Year { get; }
    public Make Make { get;  }
    public Category Category { get;  }
    public ICollection<Category> AvailableCategories { get; } = new List<Category>();
    
    private readonly int _characterLimitSize = 100;

    private Model() {}

    public Model(string code, string name, Make make, ICollection<Category> categories, short year)
    {
        CheckParamethres(code, name, categories, year);

        Code = code;
        Name = name;
        AvailableCategories = categories;
        Year = year;
        Make = make;
    }

    public Model(string code, string name, string make, short year)
    {
        CheckParamethres(code, name, year);
        
        Code = code;
        Name = name;
        Year = year;
        Make = new Make(make, make);
    }
    
    
    internal static Model Create(string code, string name, Make make, ICollection<Category> categories, short year)
        => new(code, name, make, categories, year);
    
    
    public override bool Equals(object obj)
    {
        return obj is Model make && Code == make.Code;
    }
    

    private static bool IsMakeCodeSupported(string code)
        => AvailableMakesCodes.AllCodes.Contains(code, StringComparer.InvariantCultureIgnoreCase);
    private static bool IsCategoryCodeSupported(string code)
        => AvailableCategoriesCodes.AllCodes.Contains(code, StringComparer.InvariantCultureIgnoreCase);
    
    
    private void CheckParamethres(string code, string name, ICollection<Category> categories, short year)
    {
        var makeCodeSupported = IsMakeCodeSupported(code);
        if (!makeCodeSupported)
            throw new UnsupportedMakeException(code);

        var isAnyCategoryCodeUnsupported = categories.Any(x => !IsCategoryCodeSupported(x.Code));
        if (isAnyCategoryCodeUnsupported)
            throw new UnsupportedCategoryException(code);

        CheckNameLength(code, "code");
        CheckNameLength(name, "name");
        IsYearAvailable(year);
    }  
    private void CheckParamethres(string code, string name, short year)
    {
        var makeCodeSupported = IsMakeCodeSupported(code);
        if (!makeCodeSupported)
            throw new UnsupportedMakeException(code);

        CheckNameLength(code, "code");
        CheckNameLength(name, "name");
        IsYearAvailable(year);
    }
    
    private void CheckNameLength(string property, string propertyName)
    {
        if (string.IsNullOrEmpty(property))
            throw new NameCannotBeNullException(propertyName);

        if (property.Length > _characterLimitSize)
            throw new NameIsTooLongException(propertyName);
    }
    
    private void IsYearAvailable(short year)
    {
        if (year < 1950 || year > 2023)
            throw new IncorrectCarProductionYear();
    }
}