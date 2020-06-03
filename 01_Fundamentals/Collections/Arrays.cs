using System;

namespace Collections
{
    public class Arrays
    {
        // public static void printArray(string[] arr) {
        //     foreach (var item in arr)
        //     {
        //         System.Console.WriteLine(item);
        //     }
            
        // }
        // Create an array to hold integer values 0 through 9
       public static Array zeroThruNine() {
           int[] arr = new int[10]; 
           for (int i = 0; i < arr.Length; i++)
           {
               arr[i] = i;
           }
           return arr;
       }
        // Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
       public static Array names() {
           string[] arr = {"Tim", "Martin", "Nikki", "Sara"};
           return arr;
       }
        // Create an array of length 10 that alternates between true and false values, starting with true
        public static Array trueFalse() {
            bool[] arr = new bool[10];
            for (var i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0) {
                    arr[i] = true;
                }
                else{
                    arr[i] = false;
                }
            }
            return arr;
        }
        // public static Array trueFalse() {
        //     bool[] arr = new bool[10];
        //     foreach (var item in arr)
        //     {
        //         int i = 0;
        //         if (i % 2 == 0) {
        //             item = true;
        //         }
        //         i++;
        //     }
        //     return arr;
        // }
    }
}
