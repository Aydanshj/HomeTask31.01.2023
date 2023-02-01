using System;

namespace HomeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student("P213");
            st1.Name = "asdf";

            Student st2 = new Student("P3003g");
             st2.Name = "qwert";

            Student st3 = new Student("P123");
            st3.Name = "zxcv";

            Console.WriteLine(st1.GroupNo);
            Console.WriteLine(st2.GroupNo);
            Console.WriteLine(st3.GroupNo);
        }
    }
}
