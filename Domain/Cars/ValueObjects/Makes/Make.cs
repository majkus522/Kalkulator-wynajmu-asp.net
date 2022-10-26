using Domain.Cars.Exceptions;
using Shared.ValueObjects;

namespace Domain.Cars.ValueObjects.Makes;

// As make we usually mean brand of a car, f.e Nissan
public class Make : ValueObject
{
    public string Code { get; }
    public string Name { get;}

    private Make() {}

    public Make(string code, string name)
    {
        var codeSupported = IsCodeSupported(code);
        if (!codeSupported)
            throw new UnsupportedMakeException(code);
        
        Code = code;
        Name = name;
    }
    
    private static bool IsCodeSupported(string code)
        => AvailableMakesCodes.AllCodes.Contains(code, StringComparer.InvariantCultureIgnoreCase);

    internal static Make Create(string code, string name)
        => new(code, name);

    public override bool Equals(object obj)
    {
        return obj is Make make && Code == make.Code;
    }
}