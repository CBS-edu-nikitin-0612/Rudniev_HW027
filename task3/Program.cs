using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Surface Cloning: ");

            House house = new House();
            House houseClone = house.Clone() as House;

            Console.WriteLine(house);
            Console.WriteLine(houseClone);

            Console.WriteLine(new string('-', 50));

            houseClone.NumberOfRooms = 7;
            houseClone.roof.Height = 2;
            houseClone.roof.Material = "shingles";

            Console.WriteLine(house);
            Console.WriteLine(houseClone);

            Console.WriteLine(new string('*', 50));
            Console.WriteLine("Deep Cloning: ");

            house = new House();
            houseClone = house.DeepClone() as House;

            Console.WriteLine(house);
            Console.WriteLine(houseClone);

            Console.WriteLine(new string('-', 50));

            houseClone.NumberOfRooms = 7;
            houseClone.roof.Height = 2;
            houseClone.roof.Material = "shingles";

            Console.WriteLine(house);
            Console.WriteLine(houseClone);
        }
    }
}
