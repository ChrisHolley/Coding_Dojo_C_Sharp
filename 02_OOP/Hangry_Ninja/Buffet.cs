using System;
using System.Collections.Generic;

namespace Hangry_Ninja
{
    class Buffet
    {
        public static List<Food> Menu;
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Beef Curry", 360, true, false),
                new Food("Pad Thai", 400, true, false),
                new Food("Cheesecake", 310, false, true),
                new Food("Waffles", 288, false, true),
                new Food("Nitro cold brew coffee", 40, false, false),
                new Food("Pot Roast", 666, false, false),
                new Food("Pizza", 242, false, false),
                new Food("Salad", 190, false, false),
                new Food("Kimchi", 66, true, false),
                new Food("Loco Moco", 360, false, false),
                new Food("Fried Chicken", 300, false, false),
                new Food("Beef pho all cuts", 500, false, false),
                new Food("Ramen", 400, false, false),
                new Food("Dry aged steak", 430, false, false),
                new Food("Fish Tacos", 298, true, false),
                new Food("Corn Chowder", 380, false, false)
            };
        }
        public static Food Serve()
        {
            Random rand = new Random();
            Console.WriteLine(Menu[rand.Next(Menu.Count)].Name);
            return Menu[rand.Next(Menu.Count)];
        }
    }
    class Food{
        public string Name;
        public int Calories;
        public bool IsSpicy;
        public bool IsSweet;
        public Food(string name, int cal, bool spicy, bool sweet){
            this.Name = name;
            this.Calories = cal;
            this.IsSpicy = spicy;
            this.IsSweet = sweet;
        }
    }

}
