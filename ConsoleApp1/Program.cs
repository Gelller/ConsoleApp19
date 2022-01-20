using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building(5, 2, 8, 2);
            building.Printout();

            building.FloorHeight();
            building.NumberOfApartmentsInTheEntrance();
            building.ApartmentsOnTheFloor();


            Building building2 = new Building(10, 4, 12, 3);
            building2.Printout();

            building2.FloorHeight();
            building2.NumberOfApartmentsInTheEntrance();
            building2.ApartmentsOnTheFloor();

            Console.ReadLine();
        }
    }
}
