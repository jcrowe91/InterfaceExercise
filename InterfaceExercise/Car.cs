using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Car : ICompany,IVehicle
    {
        public int trunk { get; set; }
        public string make { get; set; }

        public void Logo()
        {
            Console.WriteLine("The logo for this vehicle is located on the front grill.");
        }

        public void Tag()
        {
            Console.WriteLine("This vehicle has a valid tag.");
        }

        public void Wheels()
        {
            Console.WriteLine("This vehicle will need tires soon!");
        }

        public void Doors()
        {
            Console.WriteLine("This vehicle has doors.");
        }

        public void Antenna()
        {
            Console.WriteLine("This vehicle has a working antenna.");
        }

        public void Mirrors()
        {
            Console.WriteLine("This vehicle has adjustable mirrors.");
        }
    }
}
