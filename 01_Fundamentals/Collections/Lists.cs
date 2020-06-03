using System;
using System.Collections.Generic;

namespace Collections
{
    public class Lists
    {
        // List of Flavors
        // Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
        public static List<string> flavors() {
            List<string> flavors = new List<string>();
            flavors.Add("Vanilla");
            flavors.Add("Strawberry");
            flavors.Add("Chocolate");
            flavors.Add("Neopolitan");
            flavors.Add("Rocky Road");
            flavors.Add("Americone Dream");
            flavors.Add("Coffee");
            flavors.Add("Pistachio");
            flavors.Add("Mint");
            flavors.Add("Oreo");
            flavors.Add("Cookie Dough");
            flavors.Add("Berry Sorbet");
            flavors.Add("Birthday Cake");
            // Output the length of this list after building it
            System.Console.WriteLine(flavors.Count);
            // Output the third flavor in the list, then remove this value
            System.Console.WriteLine(flavors[2]);
            flavors.RemoveAt(2);
            System.Console.WriteLine(flavors[2]);
            // Output the new length of the list (It should just be one fewer!)
            System.Console.WriteLine(flavors.Count);
            return flavors;
        }

    }
}