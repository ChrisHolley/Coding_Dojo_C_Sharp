using System;

namespace Fundamentals_1
{
    class Fundaments {
        // Create a Loop that prints all values from 1-255
        public static void loop255(){
            int i = 1;
            while (i <= 255) {
                System.Console.WriteLine(i);
                i++;
            }
        }
        //  Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both
        public static void loop3n5(){
            for (int i = 1; i <=100; i++){
                if (i % 3 == 0 && i % 5 != 0 ){
                    System.Console.WriteLine($"divisible by 3 but not 5: {i}");
                }
                if (i % 3 != 0 && i % 5 == 0){
                    System.Console.WriteLine($"divisible by 5 but not 3: {i}");
                }
            }
        }
        //  Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5
        public static void fizzBuzz(){
            for (int i = 1; i <=100; i++){
                if (i % 3 == 0 && i % 5 != 0 ){
                    System.Console.WriteLine($"Fizz");
                }
                if (i % 3 != 0 && i % 5 == 0){
                    System.Console.WriteLine($"Buzz");
                }
                if (i % 3 == 0 && i % 5 == 0){
                    System.Console.WriteLine($"FizzBuzz");
                }
            }
        }
        //  (Optional) If you used "for" loops for your solution, try doing the same with "while" loops. Vice-versa if you used "while" loops!
    }
}





