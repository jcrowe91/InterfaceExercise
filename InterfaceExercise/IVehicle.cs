using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public void Wheels(int numOfWheels);
        public void Doors(int numOfDoors);
        public void FourByFour(bool fourWheelDrive);
        public void Towing(bool towingPackage);
    }
}
