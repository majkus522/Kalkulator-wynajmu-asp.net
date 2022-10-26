namespace Domain.Cars.ValueObjects.Makes;

internal static class AvailableMakes
{
    internal static readonly Make Acura = Make.Create(nameof(Acura), nameof(Acura));
    internal static readonly Make AlfaRomeo = Make.Create(nameof(AlfaRomeo), "Alfa Romeo");
    internal static readonly Make AstonMartin = Make.Create(nameof(AstonMartin), "Aston Martin");
    internal static readonly Make Audi = Make.Create(nameof(Audi), nameof(Audi));
    internal static readonly Make BMW = Make.Create(nameof(BMW), nameof(BMW));
    internal static readonly Make Bentley = Make.Create(nameof(Bentley), nameof(Bentley));
    internal static readonly Make Buick = Make.Create(nameof(Buick), nameof(Buick));
    internal static readonly Make Cadilac = Make.Create(nameof(Cadilac), nameof(Cadilac));
    internal static readonly Make Chevrolet = Make.Create(nameof(Chevrolet), nameof(Chevrolet));
    internal static readonly Make Chrysler = Make.Create(nameof(Chrysler), nameof(Chrysler));
    internal static readonly Make Daewoo = Make.Create(nameof(Daewoo), nameof(Daewoo));
    internal static readonly Make Daihatsu = Make.Create(nameof(Daihatsu), nameof(Daihatsu));
    internal static readonly Make Dodge = Make.Create(nameof(Dodge), nameof(Dodge));
    internal static readonly Make Eagle = Make.Create(nameof(Eagle), nameof(Eagle));
    internal static readonly Make Ferrari = Make.Create(nameof(Ferrari), nameof(Ferrari));
    internal static readonly Make Fiat = Make.Create(nameof(Fiat), nameof(Fiat));
    internal static readonly Make Fisker = Make.Create(nameof(Fisker), nameof(Fisker));
    internal static readonly Make Ford = Make.Create(nameof(Ford), nameof(Ford));
    internal static readonly Make Freighliner = Make.Create(nameof(Freighliner), nameof(Freighliner));
    internal static readonly Make GMC = Make.Create(nameof(GMC), "GMC - General Motors Company");
    internal static readonly Make Genesis = Make.Create(nameof(Genesis), nameof(Genesis));
    internal static readonly Make Geo = Make.Create(nameof(Geo), nameof(Geo));
    internal static readonly Make Honda = Make.Create(nameof(Honda), nameof(Honda));
    internal static readonly Make Hummer = Make.Create(nameof(Hummer), nameof(Hummer));
    internal static readonly Make Hyundai = Make.Create(nameof(Hyundai), nameof(Hyundai));
    internal static readonly Make Infinity = Make.Create(nameof(Infinity), nameof(Infinity));
    internal static readonly Make Isuzu = Make.Create(nameof(Isuzu), nameof(Isuzu));
    internal static readonly Make Jaguar = Make.Create(nameof(Jaguar), nameof(Jaguar));
    internal static readonly Make Jeep = Make.Create(nameof(Jeep), nameof(Jeep));
    internal static readonly Make Kla = Make.Create(nameof(Kla), nameof(Kla));
    internal static readonly Make Lamborghini = Make.Create(nameof(Lamborghini), nameof(Lamborghini));
    internal static readonly Make LandRover = Make.Create(nameof(LandRover), "Land Rover");
    internal static readonly Make Lexus = Make.Create(nameof(Lexus), nameof(Lexus));
    internal static readonly Make Lincoln = Make.Create(nameof(Lincoln), nameof(Lincoln));
    internal static readonly Make Lotus = Make.Create(nameof(Lotus), nameof(Lotus));
    internal static readonly Make Mazda = Make.Create(nameof(Mazda), nameof(Mazda));
    internal static readonly Make Maserati = Make.Create(nameof(Maserati), nameof(Maserati));
    internal static readonly Make Maybach = Make.Create(nameof(Maybach), nameof(Maybach));
    internal static readonly Make McLaren = Make.Create(nameof(McLaren), nameof(McLaren));
    internal static readonly Make MercedezBenz = Make.Create(nameof(MercedezBenz), "Mercedez-Benz");
    internal static readonly Make Mercury = Make.Create(nameof(Mercury), nameof(Mercury));
    internal static readonly Make Mini = Make.Create(nameof(Mini), nameof(Mini));
    internal static readonly Make Mitsubishi = Make.Create(nameof(Mitsubishi), nameof(Mitsubishi));
    internal static readonly Make Nissan = Make.Create(nameof(Nissan), nameof(Nissan));
    internal static readonly Make Oldsmobile = Make.Create(nameof(Oldsmobile), nameof(Oldsmobile));
    internal static readonly Make Panoz = Make.Create(nameof(Panoz), nameof(Panoz));
    internal static readonly Make Plymouth = Make.Create(nameof(Plymouth), nameof(Plymouth));
    internal static readonly Make Polestar = Make.Create(nameof(Polestar), nameof(Polestar));
    internal static readonly Make Pontiac = Make.Create(nameof(Pontiac), nameof(Pontiac));
    internal static readonly Make Porsche = Make.Create(nameof(Porsche), nameof(Porsche));
    internal static readonly Make Ram = Make.Create(nameof(Ram), nameof(Ram));
    internal static readonly Make Rivian = Make.Create(nameof(Rivian), nameof(Rivian));
    internal static readonly Make RollsRoyce = Make.Create(nameof(RollsRoyce), "Rolls-Royce");
    internal static readonly Make Saab = Make.Create(nameof(Saab), nameof(Saab));
    internal static readonly Make Saturn = Make.Create(nameof(Saturn), nameof(Saturn));
    internal static readonly Make Smart = Make.Create(nameof(Smart), nameof(Smart));
    internal static readonly Make Subaru = Make.Create(nameof(Subaru), nameof(Subaru));
    internal static readonly Make Susuki = Make.Create(nameof(Susuki), nameof(Susuki));
    internal static readonly Make Tesla = Make.Create(nameof(Tesla), nameof(Tesla));
    internal static readonly Make Toyota = Make.Create(nameof(Toyota), nameof(Toyota));
    internal static readonly Make Volkswagen = Make.Create(nameof(Volkswagen), nameof(Volkswagen));
    internal static readonly Make Volvo = Make.Create(nameof(Volvo), nameof(Volvo));

    public static readonly HashSet<Make> All = new()
    {
        Acura,
        AlfaRomeo,
        AstonMartin,
        Audi,
        BMW,
        Bentley,
        Buick,
        Cadilac,
        Chevrolet,
        Chrysler,
        Daewoo,
        Daihatsu,
        Dodge,
        Eagle,
        Ferrari,
        Fiat,
        Fisker,
        Ford,
        Freighliner,
        GMC,
        Genesis,
        Geo,
        Honda,
        Hummer,
        Hyundai,
        Infinity,
        Isuzu,
        Jaguar,
        Jeep,
        Kla,
        Lamborghini,
        LandRover,
        Lexus,
        Lincoln,
        Lotus,
        Mazda,
        Maserati,
        Maybach,
        McLaren,
        MercedezBenz,
        Mercury,
        Mini,
        Mitsubishi,
        Nissan,
        Oldsmobile,
        Panoz,
        Plymouth,
        Polestar,
        Pontiac,
        Porsche,
        Ram,
        Rivian,
        RollsRoyce,
        Saab,
        Saturn,
        Smart,
        Subaru,
        Susuki,
        Tesla,
        Toyota,
        Volkswagen,
        Volvo
    };
}