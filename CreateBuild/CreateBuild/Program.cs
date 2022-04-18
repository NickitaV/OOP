using System;

namespace CreateBuild
{
    class Program
    {
        static void Main(string[] args)
        {
            NewBuild newBuild = new NewBuild();
            newBuild.HeightOfBuild = 2800;
            newBuild.CountOfBuildFloors = 10;
            newBuild.CountOfEntrance = 5;
            newBuild.CountOfApartment = 250;
            newBuild.CountApartmentOfEntrance(out int countApartmentOfEntrance);
            newBuild.HeightOfFloors(out int heightOfFloors);
            newBuild.CountApartmentOfFloor(out int countApartmentOfFloor, countApartmentOfEntrance);
            Console.WriteLine($"Номер здания: {newBuild.NumberOfBuild} \nВысота здания: {newBuild.HeightOfBuild} \nКоличество этажей: {newBuild.CountOfBuildFloors}");
            Console.WriteLine($"Количество квартир: {newBuild.CountOfApartment}");
            Console.WriteLine($"Количество подъездов: {newBuild.CountOfEntrance} \nКоличество квартир в подъезде: {countApartmentOfEntrance} \nКоличество квартир на этаже: {countApartmentOfFloor}");
            Console.WriteLine($"Суммарное количество квартир на этаже: {countApartmentOfFloor* newBuild.CountOfEntrance}\nВысота этажа: {heightOfFloors}");
        }
    }
}
