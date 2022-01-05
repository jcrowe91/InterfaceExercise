using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //DONECreate 2 Interfaces called IVehicle & ICompany

            //DONECreate 3 classes called Car , Truck , & SUV

            //DONEIn your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //DONEIn ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //DONEIn each of your car, truck, and suv classes

            /*DONECreate 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            Car focus = new Car();
            focus.make = "Ford";
            focus.trunk = 4;
            Console.WriteLine($"This is a {focus.make} car with a {focus.trunk} foot trunk.");
            focus.Doors();
            focus.Mirrors();
            focus.Wheels();
            focus.Antenna();
            focus.Tag();
            focus.Logo();
            Console.WriteLine("----------");

            SUV equinox = new SUV();
            equinox.make = "Chevrolet";
            equinox.year = 2016;
            Console.WriteLine($"This is a {equinox.year} {equinox.make} SUV.");
            equinox.Doors();
            equinox.Mirrors();
            equinox.Wheels();
            equinox.Antenna();
            equinox.Tag();
            equinox.Logo();
            Console.WriteLine("----------");

            Truck f250 = new Truck();
            f250.make = "Ford";
            f250.bedSize = 6;
            Console.WriteLine($"This {f250.make} truck has a {f250.bedSize} foot bed on it.");
            f250.Doors();
            f250.Mirrors();
            f250.Wheels();
            f250.Antenna();
            f250.Tag();
            f250.Logo();

            Console.ReadLine();
;



            //Creatively display and organize their values

        }
    }
}
