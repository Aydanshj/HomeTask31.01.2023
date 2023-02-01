using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask
{
    internal class MountainBike : MotorBike
    {
        public override void brake()
        {
            Console.WriteLine("Mountain Bike Brake");
        }
    }
}
