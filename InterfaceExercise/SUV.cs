using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class SUV : ICompany,IVehicle
    {
        public int year { get; set; }
        public string make { get; set; }

        public void Logo()
        {
            Console.WriteLine("This vehicle has a logo on the back hatch!");
        }

        public void Tag()
        {
            Console.WriteLine("This vehicle will be due for a tag soon!");
        }

        public void Wheels()
        {
            Console.WriteLine("This SUV has very expensive tires and wheels!");
        }

        public void Doors()
        {
            Console.WriteLine("This vehicle has four doors.");
        }

        public void Antenna()
        {
            Console.WriteLine("This vehicle has an antenna and is equipped with satellite radio.");
        }

        public void Mirrors()
        {
            Console.WriteLine("This vehicle has adjustable mirrors.");
        }
    }
}
