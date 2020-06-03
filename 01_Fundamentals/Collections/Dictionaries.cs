using System;
using System.Collections.Generic;

namespace Collections
{
    // Create a dictionary that will store both string keys as well as string values
    class Dictionaries
    {
        // Add key/value pairs to this dictionary where:
        public static object favIceCream(Array names, List<string> flavors) {
            var favIceCreamDict = new Dictionary<string, string>();
            Random rand = new Random();
            
                foreach (var item in names)
                {
                    string customer = item.ToString();
                    int rn = rand.Next(0, flavors.Count);
                    string flavor = flavors[rn].ToString();
                    favIceCreamDict.Add(customer, flavor);
                }
            return favIceCreamDict;
        }
        // each key is a name from your names array
        // each value is a randomly select a flavor from your flavors list.
        // Loop through the dictionary and print out each user's name and their associated ice cream flavor
        
    }
}
