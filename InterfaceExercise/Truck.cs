using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Truck : ICompany,IVehicle
    {
        public int bedSize { get; set; } = 6;
        public string make { get; set; }

        public void Logo()
        {
            Console.WriteLine("This truck has a logo in the back window!");
        }

        public void Tag()
        {
            Console.WriteLine("This vehicle has yet to have a tag on it.");
        }

        public void Wheels()
        {
            Console.WriteLine("This vehicle is equipped with mudgrips.");
        }

        public void Doors()
        {
            Console.WriteLine("This is a two door truck.");
        }

        public void Antenna()
        {
            Console.WriteLine("This truck has a CB radio antenna on it!");
        }

        public void Mirrors()
        {
            Console.WriteLine("This truck has tow mirrors on it.");
        }

    }
}
