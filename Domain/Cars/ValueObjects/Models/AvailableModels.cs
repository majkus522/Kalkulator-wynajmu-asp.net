using Domain.Cars.ValueObjects.Categories;
using Domain.Cars.ValueObjects.Makes;

namespace Domain.Cars.ValueObjects.Models;

internal static class AvailableModels
{
    internal static readonly Model Acura9 = Model.Create(nameof(Acura9), nameof(Acura9), AvailableMakes.Acura, new List<Category>() { AvailableCategories.Minivan, AvailableCategories.SUV }, 1998);

    internal static readonly Model Acura7 = Model.Create(nameof(Acura7), nameof(Acura7), AvailableMakes.Acura, new List<Category>() { AvailableCategories.Sedan, AvailableCategories.Convertible },
        2003);

    internal static readonly Model AlfaRomeo6 = Model.Create(nameof(AlfaRomeo6), nameof(AlfaRomeo6), AvailableMakes.AlfaRomeo,
        new List<Category>() { AvailableCategories.SUV, AvailableCategories.Coupe }, 1999);

    internal static readonly Model AlfaRomeo5 = Model.Create(nameof(AlfaRomeo5), nameof(AlfaRomeo5), AvailableMakes.AlfaRomeo,
        new List<Category>() { AvailableCategories.Minivan, AvailableCategories.Van }, 1995);

    internal static readonly Model AstonMartin2 = Model.Create(nameof(AstonMartin2), nameof(AstonMartin2), AvailableMakes.AstonMartin,
        new List<Category>() { AvailableCategories.Pickup, AvailableCategories.SUV }, 1994);

    internal static readonly Model AstonMartin1 = Model.Create(nameof(AstonMartin1), nameof(AstonMartin1), AvailableMakes.AstonMartin,
        new List<Category>() { AvailableCategories.Hatchback, AvailableCategories.Van }, 2016);

    internal static readonly Model Audi8 = Model.Create(nameof(Audi8), nameof(Audi8), AvailableMakes.Audi, new List<Category>() { AvailableCategories.Convertible, AvailableCategories.Sedan }, 2008);
    internal static readonly Model Audi7 = Model.Create(nameof(Audi7), nameof(Audi7), AvailableMakes.Audi, new List<Category>() { AvailableCategories.Coupe, AvailableCategories.Hatchback }, 2011);
    internal static readonly Model BMW3 = Model.Create(nameof(BMW3), nameof(BMW3), AvailableMakes.BMW, new List<Category>() { AvailableCategories.Minivan, AvailableCategories.Van }, 2009);
    internal static readonly Model BMW5 = Model.Create(nameof(BMW5), nameof(BMW5), AvailableMakes.BMW, new List<Category>() { AvailableCategories.Convertible, AvailableCategories.Coupe }, 1996);

    internal static readonly Model Bentley4 = Model.Create(nameof(Bentley4), nameof(Bentley4), AvailableMakes.Bentley,
        new List<Category>() { AvailableCategories.Minivan, AvailableCategories.Hatchback }, 1995);

    internal static readonly Model Bentley7 = Model.Create(nameof(Bentley7), nameof(Bentley7), AvailableMakes.Bentley,
        new List<Category>() { AvailableCategories.Coupe, AvailableCategories.Hatchback }, 1995);

    internal static readonly Model Buick6 = Model.Create(nameof(Buick6), nameof(Buick6), AvailableMakes.Buick, new List<Category>() { AvailableCategories.Minivan, AvailableCategories.Van }, 2009);
    internal static readonly Model Buick2 = Model.Create(nameof(Buick2), nameof(Buick2), AvailableMakes.Buick, new List<Category>() { AvailableCategories.Hatchback, AvailableCategories.SUV }, 1994);

    internal static readonly Model Cadilac3 = Model.Create(nameof(Cadilac3), nameof(Cadilac3), AvailableMakes.Cadilac, new List<Category>() { AvailableCategories.Minivan, AvailableCategories.Sedan },
        2014);

    internal static readonly Model Cadilac4 = Model.Create(nameof(Cadilac4), nameof(Cadilac4), AvailableMakes.Cadilac, new List<Category>() { AvailableCategories.Pickup, AvailableCategories.Minivan },
        2018);

    internal static readonly Model Chevrolet8 = Model.Create(nameof(Chevrolet8), nameof(Chevrolet8), AvailableMakes.Chevrolet,
        new List<Category>() { AvailableCategories.Van, AvailableCategories.Convertible }, 2009);

    internal static readonly Model Chevrolet5 = Model.Create(nameof(Chevrolet5), nameof(Chevrolet5), AvailableMakes.Chevrolet,
        new List<Category>() { AvailableCategories.Hatchback, AvailableCategories.Pickup }, 2009);

    internal static readonly Model Chrysler3 = Model.Create(nameof(Chrysler3), nameof(Chrysler3), AvailableMakes.Chrysler, new List<Category>() { AvailableCategories.Sedan, AvailableCategories.Van },
        2014);

    internal static readonly Model Chrysler5 = Model.Create(nameof(Chrysler5), nameof(Chrysler5), AvailableMakes.Chrysler, new List<Category>() { AvailableCategories.Van, AvailableCategories.SUV },
        2010);

    internal static readonly Model Daewoo9 = Model.Create(nameof(Daewoo9), nameof(Daewoo9), AvailableMakes.Daewoo, new List<Category>() { AvailableCategories.Minivan, AvailableCategories.SUV }, 2012);
    internal static readonly Model Daewoo4 = Model.Create(nameof(Daewoo4), nameof(Daewoo4), AvailableMakes.Daewoo, new List<Category>() { AvailableCategories.Sedan, AvailableCategories.Van }, 1997);

    internal static readonly Model Daihatsu6 = Model.Create(nameof(Daihatsu6), nameof(Daihatsu6), AvailableMakes.Daihatsu,
        new List<Category>() { AvailableCategories.Hatchback, AvailableCategories.Coupe }, 2010);

    internal static readonly Model Daihatsu4 = Model.Create(nameof(Daihatsu4), nameof(Daihatsu4), AvailableMakes.Daihatsu, new List<Category>() { AvailableCategories.Van, AvailableCategories.Sedan },
        2017);

    internal static readonly Model Dodge7 = Model.Create(nameof(Dodge7), nameof(Dodge7), AvailableMakes.Dodge, new List<Category>() { AvailableCategories.Convertible, AvailableCategories.Coupe },
        2019);

    internal static readonly Model Dodge4 = Model.Create(nameof(Dodge4), nameof(Dodge4), AvailableMakes.Dodge, new List<Category>() { AvailableCategories.Minivan, AvailableCategories.Hatchback },
        1990);

    internal static readonly Model Eagle9 = Model.Create(nameof(Eagle9), nameof(Eagle9), AvailableMakes.Eagle, new List<Category>() { AvailableCategories.SUV, AvailableCategories.Van }, 2018);
    internal static readonly Model Eagle1 = Model.Create(nameof(Eagle1), nameof(Eagle1), AvailableMakes.Eagle, new List<Category>() { AvailableCategories.Coupe, AvailableCategories.Van }, 1998);

    internal static readonly Model Ferrari6 = Model.Create(nameof(Ferrari6), nameof(Ferrari6), AvailableMakes.Ferrari, new List<Category>() { AvailableCategories.SUV, AvailableCategories.Minivan },
        2021);

    internal static readonly Model Ferrari9 = Model.Create(nameof(Ferrari9), nameof(Ferrari9), AvailableMakes.Ferrari,
        new List<Category>() { AvailableCategories.Convertible, AvailableCategories.Sedan }, 2016);

    internal static readonly Model Fiat7 = Model.Create(nameof(Fiat7), nameof(Fiat7), AvailableMakes.Fiat, new List<Category>() { AvailableCategories.Coupe, AvailableCategories.Van }, 2001);
    internal static readonly Model Fiat4 = Model.Create(nameof(Fiat4), nameof(Fiat4), AvailableMakes.Fiat, new List<Category>() { AvailableCategories.Van, AvailableCategories.Pickup }, 2017);

    internal static readonly Model Fisker8 = Model.Create(nameof(Fisker8), nameof(Fisker8), AvailableMakes.Fisker,
        new List<Category>() { AvailableCategories.Convertible, AvailableCategories.Hatchback }, 1999);

    internal static readonly Model Fisker7 = Model.Create(nameof(Fisker7), nameof(Fisker7), AvailableMakes.Fisker, new List<Category>() { AvailableCategories.Minivan, AvailableCategories.Sedan },
        1999);

    internal static readonly Model Ford5 = Model.Create(nameof(Ford5), nameof(Ford5), AvailableMakes.Ford, new List<Category>() { AvailableCategories.Van, AvailableCategories.Sedan }, 2005);
    internal static readonly Model Ford7 = Model.Create(nameof(Ford7), nameof(Ford7), AvailableMakes.Ford, new List<Category>() { AvailableCategories.SUV, AvailableCategories.Van }, 2019);

    internal static readonly Model Freighliner5 = Model.Create(nameof(Freighliner5), nameof(Freighliner5), AvailableMakes.Freighliner,
        new List<Category>() { AvailableCategories.SUV, AvailableCategories.Sedan }, 2018);

    internal static readonly Model Freighliner4 = Model.Create(nameof(Freighliner4), nameof(Freighliner4), AvailableMakes.Freighliner,
        new List<Category>() { AvailableCategories.Van, AvailableCategories.Convertible }, 1993);

    internal static readonly Model GMC3 = Model.Create(nameof(GMC3), nameof(GMC3), AvailableMakes.GMC, new List<Category>() { AvailableCategories.Minivan, AvailableCategories.Pickup }, 2000);
    internal static readonly Model GMC8 = Model.Create(nameof(GMC8), nameof(GMC8), AvailableMakes.GMC, new List<Category>() { AvailableCategories.Minivan, AvailableCategories.Sedan }, 1990);

    internal static readonly Model Genesis7 = Model.Create(nameof(Genesis7), nameof(Genesis7), AvailableMakes.Genesis, new List<Category>() { AvailableCategories.SUV, AvailableCategories.Minivan },
        2013);

    internal static readonly Model Genesis9 = Model.Create(nameof(Genesis9), nameof(Genesis9), AvailableMakes.Genesis,
        new List<Category>() { AvailableCategories.Minivan, AvailableCategories.Convertible }, 2002);

    internal static readonly Model Geo5 = Model.Create(nameof(Geo5), nameof(Geo5), AvailableMakes.Geo, new List<Category>() { AvailableCategories.Sedan, AvailableCategories.Minivan }, 2005);
    internal static readonly Model Geo2 = Model.Create(nameof(Geo2), nameof(Geo2), AvailableMakes.Geo, new List<Category>() { AvailableCategories.Coupe, AvailableCategories.Pickup }, 2018);

    internal static readonly Model Honda4 = Model.Create(nameof(Honda4), nameof(Honda4), AvailableMakes.Honda, new List<Category>() { AvailableCategories.Minivan, AvailableCategories.Hatchback },
        2007);

    internal static readonly Model Honda2 = Model.Create(nameof(Honda2), nameof(Honda2), AvailableMakes.Honda, new List<Category>() { AvailableCategories.Van, AvailableCategories.SUV }, 2017);

    internal static readonly Model Hummer8 = Model.Create(nameof(Hummer8), nameof(Hummer8), AvailableMakes.Hummer,
        new List<Category>() { AvailableCategories.Convertible, AvailableCategories.Hatchback }, 2012);

    internal static readonly Model Hummer7 = Model.Create(nameof(Hummer7), nameof(Hummer7), AvailableMakes.Hummer, new List<Category>() { AvailableCategories.Coupe, AvailableCategories.Hatchback },
        2014);

    internal static readonly Model Hyundai7 = Model.Create(nameof(Hyundai7), nameof(Hyundai7), AvailableMakes.Hyundai, new List<Category>() { AvailableCategories.Pickup, AvailableCategories.Van },
        1999);

    internal static readonly Model Hyundai5 = Model.Create(nameof(Hyundai5), nameof(Hyundai5), AvailableMakes.Hyundai,
        new List<Category>() { AvailableCategories.Convertible, AvailableCategories.Pickup }, 2006);

    internal static readonly Model Infinity3 = Model.Create(nameof(Infinity3), nameof(Infinity3), AvailableMakes.Infinity, new List<Category>() { AvailableCategories.Pickup, AvailableCategories.SUV },
        2014);

    internal static readonly Model Infinity6 = Model.Create(nameof(Infinity6), nameof(Infinity6), AvailableMakes.Infinity,
        new List<Category>() { AvailableCategories.Convertible, AvailableCategories.Pickup }, 2007);

    internal static readonly Model Isuzu5 = Model.Create(nameof(Isuzu5), nameof(Isuzu5), AvailableMakes.Isuzu, new List<Category>() { AvailableCategories.Convertible, AvailableCategories.Pickup },
        1995);

    internal static readonly Model Isuzu6 = Model.Create(nameof(Isuzu6), nameof(Isuzu6), AvailableMakes.Isuzu, new List<Category>() { AvailableCategories.Minivan, AvailableCategories.Convertible },
        2004);

    internal static readonly Model Jaguar2 = Model.Create(nameof(Jaguar2), nameof(Jaguar2), AvailableMakes.Jaguar, new List<Category>() { AvailableCategories.Van, AvailableCategories.SUV }, 2013);

    internal static readonly Model Jaguar5 = Model.Create(nameof(Jaguar5), nameof(Jaguar5), AvailableMakes.Jaguar,
        new List<Category>() { AvailableCategories.Minivan, AvailableCategories.Convertible }, 2016);

    internal static readonly Model Jeep2 = Model.Create(nameof(Jeep2), nameof(Jeep2), AvailableMakes.Jeep, new List<Category>() { AvailableCategories.Van, AvailableCategories.Sedan }, 1993);
    internal static readonly Model Jeep9 = Model.Create(nameof(Jeep9), nameof(Jeep9), AvailableMakes.Jeep, new List<Category>() { AvailableCategories.Hatchback, AvailableCategories.SUV }, 2003);
    internal static readonly Model Kla3 = Model.Create(nameof(Kla3), nameof(Kla3), AvailableMakes.Kla, new List<Category>() { AvailableCategories.Sedan, AvailableCategories.Coupe }, 2004);
    internal static readonly Model Kla7 = Model.Create(nameof(Kla7), nameof(Kla7), AvailableMakes.Kla, new List<Category>() { AvailableCategories.SUV, AvailableCategories.Hatchback }, 2012);

    internal static readonly Model Lamborghini6 = Model.Create(nameof(Lamborghini6), nameof(Lamborghini6), AvailableMakes.Lamborghini,
        new List<Category>() { AvailableCategories.SUV, AvailableCategories.Hatchback }, 1994);

    internal static readonly Model Lamborghini9 = Model.Create(nameof(Lamborghini9), nameof(Lamborghini9), AvailableMakes.Lamborghini,
        new List<Category>() { AvailableCategories.Coupe, AvailableCategories.Pickup }, 2002);

    internal static readonly Model LandRover7 = Model.Create(nameof(LandRover7), nameof(LandRover7), AvailableMakes.LandRover,
        new List<Category>() { AvailableCategories.Sedan, AvailableCategories.Van }, 2018);

    internal static readonly Model LandRover5 = Model.Create(nameof(LandRover5), nameof(LandRover5), AvailableMakes.LandRover,
        new List<Category>() { AvailableCategories.Sedan, AvailableCategories.Pickup }, 2000);

    internal static readonly Model Lexus4 = Model.Create(nameof(Lexus4), nameof(Lexus4), AvailableMakes.Lexus, new List<Category>() { AvailableCategories.Hatchback, AvailableCategories.Minivan },
        1990);

    internal static readonly Model Lexus9 = Model.Create(nameof(Lexus9), nameof(Lexus9), AvailableMakes.Lexus, new List<Category>() { AvailableCategories.Minivan, AvailableCategories.Convertible },
        1997);

    internal static readonly Model Lincoln5 = Model.Create(nameof(Lincoln5), nameof(Lincoln5), AvailableMakes.Lincoln, new List<Category>() { AvailableCategories.Pickup, AvailableCategories.Van },
        2019);

    internal static readonly Model Lincoln9 = Model.Create(nameof(Lincoln9), nameof(Lincoln9), AvailableMakes.Lincoln, new List<Category>() { AvailableCategories.Minivan, AvailableCategories.SUV },
        2016);

    internal static readonly Model Lotus9 = Model.Create(nameof(Lotus9), nameof(Lotus9), AvailableMakes.Lotus, new List<Category>() { AvailableCategories.Van, AvailableCategories.Coupe }, 2014);
    internal static readonly Model Lotus7 = Model.Create(nameof(Lotus7), nameof(Lotus7), AvailableMakes.Lotus, new List<Category>() { AvailableCategories.Pickup, AvailableCategories.Sedan }, 2001);
    internal static readonly Model Mazda2 = Model.Create(nameof(Mazda2), nameof(Mazda2), AvailableMakes.Mazda, new List<Category>() { AvailableCategories.Pickup, AvailableCategories.SUV }, 2021);
    internal static readonly Model Mazda3 = Model.Create(nameof(Mazda3), nameof(Mazda3), AvailableMakes.Mazda, new List<Category>() { AvailableCategories.Van, AvailableCategories.Hatchback }, 2002);

    internal static readonly Model Maserati2 = Model.Create(nameof(Maserati2), nameof(Maserati2), AvailableMakes.Maserati,
        new List<Category>() { AvailableCategories.Hatchback, AvailableCategories.Sedan }, 2000);

    internal static readonly Model Maserati7 = Model.Create(nameof(Maserati7), nameof(Maserati7), AvailableMakes.Maserati,
        new List<Category>() { AvailableCategories.Van, AvailableCategories.Hatchback }, 2005);

    internal static readonly Model Maybach6 = Model.Create(nameof(Maybach6), nameof(Maybach6), AvailableMakes.Maybach, new List<Category>() { AvailableCategories.SUV, AvailableCategories.Coupe },
        2013);

    internal static readonly Model Maybach2 = Model.Create(nameof(Maybach2), nameof(Maybach2), AvailableMakes.Maybach, new List<Category>() { AvailableCategories.Van, AvailableCategories.Sedan },
        2005);

    internal static readonly Model McLaren9 = Model.Create(nameof(McLaren9), nameof(McLaren9), AvailableMakes.McLaren,
        new List<Category>() { AvailableCategories.Coupe, AvailableCategories.Convertible }, 1997);

    internal static readonly Model McLaren2 = Model.Create(nameof(McLaren2), nameof(McLaren2), AvailableMakes.McLaren, new List<Category>() { AvailableCategories.Van, AvailableCategories.Hatchback },
        2018);

    internal static readonly Model MercedezBenz9 = Model.Create(nameof(MercedezBenz9), nameof(MercedezBenz9), AvailableMakes.MercedezBenz,
        new List<Category>() { AvailableCategories.SUV, AvailableCategories.Convertible }, 1997);

    internal static readonly Model MercedezBenz7 = Model.Create(nameof(MercedezBenz7), nameof(MercedezBenz7), AvailableMakes.MercedezBenz,
        new List<Category>() { AvailableCategories.Pickup, AvailableCategories.Minivan }, 2009);

    internal static readonly Model Mercury3 = Model.Create(nameof(Mercury3), nameof(Mercury3), AvailableMakes.Mercury, new List<Category>() { AvailableCategories.Van, AvailableCategories.Sedan },
        2002);

    internal static readonly Model Mercury8 = Model.Create(nameof(Mercury8), nameof(Mercury8), AvailableMakes.Mercury, new List<Category>() { AvailableCategories.Pickup, AvailableCategories.Sedan },
        2007);

    internal static readonly Model Mini3 = Model.Create(nameof(Mini3), nameof(Mini3), AvailableMakes.Mini, new List<Category>() { AvailableCategories.Van, AvailableCategories.Hatchback }, 2004);
    internal static readonly Model Mini7 = Model.Create(nameof(Mini7), nameof(Mini7), AvailableMakes.Mini, new List<Category>() { AvailableCategories.Convertible, AvailableCategories.Pickup }, 2003);

    internal static readonly Model Mitsubishi5 = Model.Create(nameof(Mitsubishi5), nameof(Mitsubishi5), AvailableMakes.Mitsubishi,
        new List<Category>() { AvailableCategories.Hatchback, AvailableCategories.Convertible }, 2010);

    internal static readonly Model Mitsubishi2 = Model.Create(nameof(Mitsubishi2), nameof(Mitsubishi2), AvailableMakes.Mitsubishi,
        new List<Category>() { AvailableCategories.Pickup, AvailableCategories.Coupe }, 1990);

    internal static readonly Model Nissan2 = Model.Create(nameof(Nissan2), nameof(Nissan2), AvailableMakes.Nissan, new List<Category>() { AvailableCategories.SUV, AvailableCategories.Hatchback },
        2018);

    internal static readonly Model Nissan7 = Model.Create(nameof(Nissan7), nameof(Nissan7), AvailableMakes.Nissan,
        new List<Category>() { AvailableCategories.Convertible, AvailableCategories.Hatchback }, 2011);

    internal static readonly Model Oldsmobile7 = Model.Create(nameof(Oldsmobile7), nameof(Oldsmobile7), AvailableMakes.Oldsmobile,
        new List<Category>() { AvailableCategories.SUV, AvailableCategories.Sedan }, 2003);

    internal static readonly Model Oldsmobile4 = Model.Create(nameof(Oldsmobile4), nameof(Oldsmobile4), AvailableMakes.Oldsmobile,
        new List<Category>() { AvailableCategories.Minivan, AvailableCategories.Hatchback }, 2011);

    internal static readonly Model Panoz5 = Model.Create(nameof(Panoz5), nameof(Panoz5), AvailableMakes.Panoz, new List<Category>() { AvailableCategories.Pickup, AvailableCategories.Minivan }, 2015);
    internal static readonly Model Panoz2 = Model.Create(nameof(Panoz2), nameof(Panoz2), AvailableMakes.Panoz, new List<Category>() { AvailableCategories.Hatchback, AvailableCategories.Coupe }, 2019);

    internal static readonly Model Plymouth8 = Model.Create(nameof(Plymouth8), nameof(Plymouth8), AvailableMakes.Plymouth, new List<Category>() { AvailableCategories.Van, AvailableCategories.SUV },
        2007);

    internal static readonly Model Plymouth7 = Model.Create(nameof(Plymouth7), nameof(Plymouth7), AvailableMakes.Plymouth,
        new List<Category>() { AvailableCategories.Hatchback, AvailableCategories.Convertible }, 1996);

    internal static readonly Model Polestar6 = Model.Create(nameof(Polestar6), nameof(Polestar6), AvailableMakes.Polestar,
        new List<Category>() { AvailableCategories.Minivan, AvailableCategories.Pickup }, 2021);

    internal static readonly Model Polestar3 = Model.Create(nameof(Polestar3), nameof(Polestar3), AvailableMakes.Polestar,
        new List<Category>() { AvailableCategories.Convertible, AvailableCategories.Hatchback }, 2004);

    internal static readonly Model Pontiac5 = Model.Create(nameof(Pontiac5), nameof(Pontiac5), AvailableMakes.Pontiac,
        new List<Category>() { AvailableCategories.Hatchback, AvailableCategories.Sedan }, 2013);

    internal static readonly Model Pontiac6 = Model.Create(nameof(Pontiac6), nameof(Pontiac6), AvailableMakes.Pontiac, new List<Category>() { AvailableCategories.Minivan, AvailableCategories.Sedan },
        2012);

    internal static readonly Model Porsche8 = Model.Create(nameof(Porsche8), nameof(Porsche8), AvailableMakes.Porsche,
        new List<Category>() { AvailableCategories.Hatchback, AvailableCategories.Pickup }, 1993);

    internal static readonly Model Porsche5 = Model.Create(nameof(Porsche5), nameof(Porsche5), AvailableMakes.Porsche, new List<Category>() { AvailableCategories.Pickup, AvailableCategories.Van },
        1995);

    internal static readonly Model Ram2 = Model.Create(nameof(Ram2), nameof(Ram2), AvailableMakes.Ram, new List<Category>() { AvailableCategories.Minivan, AvailableCategories.Van }, 2005);
    internal static readonly Model Ram6 = Model.Create(nameof(Ram6), nameof(Ram6), AvailableMakes.Ram, new List<Category>() { AvailableCategories.SUV, AvailableCategories.Convertible }, 1998);
    internal static readonly Model Rivian8 = Model.Create(nameof(Rivian8), nameof(Rivian8), AvailableMakes.Rivian, new List<Category>() { AvailableCategories.Minivan, AvailableCategories.SUV }, 1994);

    internal static readonly Model Rivian9 = Model.Create(nameof(Rivian9), nameof(Rivian9), AvailableMakes.Rivian, new List<Category>() { AvailableCategories.Convertible, AvailableCategories.Pickup },
        2007);

    internal static readonly Model RollsRoyce4 = Model.Create(nameof(RollsRoyce4), nameof(RollsRoyce4), AvailableMakes.RollsRoyce,
        new List<Category>() { AvailableCategories.Hatchback, AvailableCategories.Van }, 2015);

    internal static readonly Model RollsRoyce3 = Model.Create(nameof(RollsRoyce3), nameof(RollsRoyce3), AvailableMakes.RollsRoyce,
        new List<Category>() { AvailableCategories.SUV, AvailableCategories.Pickup }, 1990);

    internal static readonly Model Saab1 = Model.Create(nameof(Saab1), nameof(Saab1), AvailableMakes.Saab, new List<Category>() { AvailableCategories.Coupe, AvailableCategories.Van }, 1998);
    internal static readonly Model Saab7 = Model.Create(nameof(Saab7), nameof(Saab7), AvailableMakes.Saab, new List<Category>() { AvailableCategories.SUV, AvailableCategories.Pickup }, 2009);

    internal static readonly Model Saturn4 = Model.Create(nameof(Saturn4), nameof(Saturn4), AvailableMakes.Saturn, new List<Category>() { AvailableCategories.Hatchback, AvailableCategories.Pickup },
        2016);

    internal static readonly Model Saturn9 = Model.Create(nameof(Saturn9), nameof(Saturn9), AvailableMakes.Saturn, new List<Category>() { AvailableCategories.Pickup, AvailableCategories.Minivan },
        1998);

    internal static readonly Model Smart1 = Model.Create(nameof(Smart1), nameof(Smart1), AvailableMakes.Smart, new List<Category>() { AvailableCategories.Hatchback, AvailableCategories.Minivan },
        2002);

    internal static readonly Model Smart5 = Model.Create(nameof(Smart5), nameof(Smart5), AvailableMakes.Smart, new List<Category>() { AvailableCategories.Van, AvailableCategories.Pickup }, 1993);

    internal static readonly Model Subaru1 = Model.Create(nameof(Subaru1), nameof(Subaru1), AvailableMakes.Subaru, new List<Category>() { AvailableCategories.Convertible, AvailableCategories.Coupe },
        2019);

    internal static readonly Model Subaru2 = Model.Create(nameof(Subaru2), nameof(Subaru2), AvailableMakes.Subaru, new List<Category>() { AvailableCategories.Pickup, AvailableCategories.Hatchback },
        1992);

    internal static readonly Model Susuki2 = Model.Create(nameof(Susuki2), nameof(Susuki2), AvailableMakes.Susuki, new List<Category>() { AvailableCategories.Hatchback, AvailableCategories.Sedan },
        2010);

    internal static readonly Model Susuki1 = Model.Create(nameof(Susuki1), nameof(Susuki1), AvailableMakes.Susuki, new List<Category>() { AvailableCategories.Coupe, AvailableCategories.Hatchback },
        1995);

    internal static readonly Model Tesla9 = Model.Create(nameof(Tesla9), nameof(Tesla9), AvailableMakes.Tesla, new List<Category>() { AvailableCategories.Minivan, AvailableCategories.Van }, 2015);
    internal static readonly Model Tesla6 = Model.Create(nameof(Tesla6), nameof(Tesla6), AvailableMakes.Tesla, new List<Category>() { AvailableCategories.Coupe, AvailableCategories.Sedan }, 2000);
    internal static readonly Model Toyota1 = Model.Create(nameof(Toyota1), nameof(Toyota1), AvailableMakes.Toyota, new List<Category>() { AvailableCategories.Coupe, AvailableCategories.SUV }, 1995);

    internal static readonly Model Toyota6 = Model.Create(nameof(Toyota6), nameof(Toyota6), AvailableMakes.Toyota, new List<Category>() { AvailableCategories.Minivan, AvailableCategories.Sedan },
        2011);

    internal static readonly Model Volkswagen7 = Model.Create(nameof(Volkswagen7), nameof(Volkswagen7), AvailableMakes.Volkswagen,
        new List<Category>() { AvailableCategories.Hatchback, AvailableCategories.Van }, 2011);

    internal static readonly Model Volkswagen1 = Model.Create(nameof(Volkswagen1), nameof(Volkswagen1), AvailableMakes.Volkswagen,
        new List<Category>() { AvailableCategories.Sedan, AvailableCategories.Convertible }, 1996);

    internal static readonly Model Volvo5 = Model.Create(nameof(Volvo5), nameof(Volvo5), AvailableMakes.Volvo, new List<Category>() { AvailableCategories.Sedan, AvailableCategories.SUV }, 2008);
    internal static readonly Model Volvo7 = Model.Create(nameof(Volvo7), nameof(Volvo7), AvailableMakes.Volvo, new List<Category>() { AvailableCategories.Minivan, AvailableCategories.Sedan }, 2005);


    public static readonly HashSet<Model> All = new()
    {
        Acura9,
        Acura7,
        AlfaRomeo6,
        AlfaRomeo5,
        AstonMartin2,
        AstonMartin1,
        Audi8,
        Audi7,
        BMW3,
        BMW5,
        Bentley4,
        Bentley7,
        Buick6,
        Buick2,
        Cadilac3,
        Cadilac4,
        Chevrolet8,
        Chevrolet5,
        Chrysler3,
        Chrysler5,
        Daewoo9,
        Daewoo4,
        Daihatsu6,
        Daihatsu4,
        Dodge7,
        Dodge4,
        Eagle9,
        Eagle1,
        Ferrari6,
        Ferrari9,
        Fiat7,
        Fiat4,
        Fisker8,
        Fisker7,
        Ford5,
        Ford7,
        Freighliner5,
        Freighliner4,
        GMC3,
        GMC8,
        Genesis7,
        Genesis9,
        Geo5,
        Geo2,
        Honda4,
        Honda2,
        Hummer8,
        Hummer7,
        Hyundai7,
        Hyundai5,
        Infinity3,
        Infinity6,
        Isuzu5,
        Isuzu6,
        Jaguar2,
        Jaguar5,
        Jeep2,
        Jeep9,
        Kla3,
        Kla7,
        Lamborghini6,
        Lamborghini9,
        LandRover7,
        LandRover5,
        Lexus4,
        Lexus9,
        Lincoln5,
        Lincoln9,
        Lotus9,
        Lotus7,
        Mazda2,
        Mazda3,
        Maserati2,
        Maserati7,
        Maybach6,
        Maybach2,
        McLaren9,
        McLaren2,
        MercedezBenz9,
        MercedezBenz7,
        Mercury3,
        Mercury8,
        Mini3,
        Mini7,
        Mitsubishi5,
        Mitsubishi2,
        Nissan2,
        Nissan7,
        Oldsmobile7,
        Oldsmobile4,
        Panoz5,
        Panoz2,
        Plymouth8,
        Plymouth7,
        Polestar6,
        Polestar3,
        Pontiac5,
        Pontiac6,
        Porsche8,
        Porsche5,
        Ram2,
        Ram6,
        Rivian8,
        Rivian9,
        RollsRoyce4,
        RollsRoyce3,
        Saab1,
        Saab7,
        Saturn4,
        Saturn9,
        Smart1,
        Smart5,
        Subaru1,
        Subaru2,
        Susuki2,
        Susuki1,
        Tesla9,
        Tesla6,
        Toyota1,
        Toyota6,
        Volkswagen7,
        Volkswagen1,
        Volvo5,
        Volvo7,
    };
}