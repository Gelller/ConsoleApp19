using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Building
    {
        private static int _counterID = 1;
        private int _id;
        private int _height;
        private int _numberOfBurns;
        private int _numberOfApartments;
        private int _numberOfEntrances;
        private int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                _counterID++;
            }
        }
        private int Height { get; set; }
        private int NumberOfBurns { get; set; }
        private int NumberOfApartments { get; set; }
        private int NumberOfEntrances { get; set; }

        public Building(int height, int numberOfBurns, int numberOfApartments, int numberOfEntrances)
        {
            Id = _counterID;
            Height = height;
            NumberOfBurns = numberOfBurns;
            NumberOfApartments = numberOfApartments;
            NumberOfEntrances = numberOfEntrances;
        }

        public void Printout()
        {
            Console.WriteLine($"ID: {Id}  Высота: {Height} Количество этажей: { NumberOfBurns} Количество квартир: {NumberOfApartments}  Количество подъездов: { NumberOfEntrances}");
        }

        public void FloorHeight()
        {
            int floorHeight = Height / NumberOfBurns;
            Console.WriteLine($"Высота этажа: {floorHeight} ");
        }

        public void NumberOfApartmentsInTheEntrance()
        {
            int numberOfApartments = NumberOfApartments / NumberOfEntrances;
            Console.WriteLine($"Количество квартир в подъезде: {numberOfApartments} ");

        }

        public void ApartmentsOnTheFloor()
        {
            int apartmentsOnTheFloor = (NumberOfApartments / NumberOfEntrances)/ NumberOfBurns;
            Console.WriteLine($"Количества квартир на этаже : {apartmentsOnTheFloor} ");

        }
    }
}
