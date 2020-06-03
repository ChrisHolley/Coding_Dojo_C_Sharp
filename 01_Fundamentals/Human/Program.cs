using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Human Jimmy = new Human("Jimmy");
            System.Console.WriteLine(Jimmy);
            Human Timmy = new Human("Timmy", 999, -1, 0, 1300);
            System.Console.WriteLine(Timmy);
            Timmy.Attack(Jimmy);
        }
    }
}
