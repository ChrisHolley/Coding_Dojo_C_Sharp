using System;
using System.Collections.Generic;

namespace boxUnbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<object> box = new List<object>();
            box.Add(7);
            box.Add(28);
            box.Add(-1);
            box.Add(true);
            box.Add("chair");
            System.Console.WriteLine(box);
            int sum = 0;
            int isInt = 0;
            foreach (var item in box)
            {
                if (item is int){
                    System.Console.WriteLine(item);
                    isInt = (int)item;
                    sum += isInt;
                }
            }
            System.Console.WriteLine(sum);
        }
    }
}
