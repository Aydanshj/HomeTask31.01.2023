using System;

namespace HomeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SportsBike s1 = new SportsBike();
            s1.brake();

            MountainBike m1 = new MountainBike();
            m1.brake();

            Console.ReadLine();
        }
    }
}
