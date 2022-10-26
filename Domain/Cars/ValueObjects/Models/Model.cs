using Domain.Cars.ValueObjects.Makes;
using Shared.ValueObjects;

namespace Domain.Cars.ValueObjects.Models;

public class Model : ValueObject
{
    public string Code { get; }
    public string Name { get;}
    
    public Make Make { get;  }

    private Model() {}

    public Model(string code, string name, Make make)
    {
        Code = code;
        Name = name;
        Make = make;
    }

    internal static Model Create(string code, string name, Make make)
        => new(code, name, make);

    public override bool Equals(object obj)
    {
        return obj is Model make && Code == make.Code;
    }
}