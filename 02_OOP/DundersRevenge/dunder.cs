using System;


namespace DundersRevenge
{
    class Human
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        public int health;    
        // add a public "getter" property to access health
        public int Health 
        {
            get { return health; }
        }
        public int barrier;
        public int Barrier
        {
            get { return barrier; }
        }
        
        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        //  Create a Human class with four public fields: Name (string) , Strength (int), Intelligence (int), Dexterity (int)
    //  Add a constructor method that takes a string to initialize Name - and that will initialize Strength, Intelligence, and Dexterity to a default value of 3, and health to default value of 100
        public Human(string name) {
            this.Name = name;
            this.Strength = 3;
            this.Intelligence = 3;
            this.Dexterity = 3;
            this.health = 100;
            this.barrier = 0;
            
        } 
//  Let's create an additional constructor that accepts 5 parameters, so we can set custom values for every field.
        public Human(string name, int strength, int intelligence, int dexterity, int health){
            this.Name = name;
            this.Strength = strength;
            this.Intelligence = intelligence;
            this.Dexterity = dexterity;
            this.health = health;
        }
        
        
//  Now add a new method called Attack, which when invoked, should reduce the health of a Human object that is passed as a parameter. The damage done should be 5 * strength (5 points of damage to the attacked, for each 1 point of strength of the attacker). This method should return the remaining health of the target object.
        public int Attack(Human target)
        {
            int dmg = this.Strength * 5;
            target.health = target.health - dmg;
            if (target.health <= 0){
                target.health = 0;
                System.Console.WriteLine($"{target.Name} took fatal damage!!! Health is {target.health}");
            }
            else {
                System.Console.WriteLine($"{this.Name} attacked {target.Name} for {dmg} damage!!");
            }
            return target.health;
        }
        public void Input(Enemy enemy){
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine(string.Format( @"

            -----Actions------                  
            1: Magic Missile                    || Dunder's Health: {0} ||
            2: Barrier                          || Dunder's Barrier: {1} ||
            3: First Aid
            4: Wait                             || {2}'s Health: {3} ||
                                                || {2}'s Barrier: {4} ||


            ", this.health, this.barrier, enemy.Name, enemy.Health, enemy.Barrier));
            System.Console.WriteLine("Type in a number to perform action(1-4)");
            string input = Console.ReadLine();
            Console.Clear();
            System.Console.WriteLine(" ");
            System.Console.WriteLine(" ");
            System.Console.WriteLine("=========================================================");
            if (input == "1"){
                MagicMissile(enemy);
            }
            else if (input == "2"){
                CreateBarrier();
            }
            else if (input == "3"){

            }
            else if (input == "4"){

            }
        }
        public int MagicMissile(Enemy target)
        {
            int dmg = this.Intelligence * 1;
            target.health = target.health - dmg;
            if (target.health <= 0){
                target.health = 0;
                Console.ForegroundColor = ConsoleColor.Cyan;
                System.Console.WriteLine($"{target.Name} took fatal damage!!! Health is {target.health}");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else {
                Console.ForegroundColor = ConsoleColor.Cyan;
                System.Console.WriteLine($"{this.Name} attacked {target.Name} for {dmg} damage!!");
                Console.ForegroundColor = ConsoleColor.Gray;

            }
            return target.health;
        }
        public int CreateBarrier()
        {
            int power = this.Intelligence * 5;
            this.barrier = this.barrier + power;
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine($"{this.Name} created a {this.barrier}hp magical barrier");
            Console.ForegroundColor = ConsoleColor.Gray;

            return this.barrier;
        }
        public int FirstAid(Enemy target)
        {
            int dmg = this.Strength * 5;
            target.health = target.health - dmg;
            if (target.health <= 0){
                target.health = 0;
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine($"{target.Name} took fatal damage!!! Health is {target.health}");
                Console.ForegroundColor = ConsoleColor.Gray;

            }
            else {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine($"{this.Name} attacked {target.Name} for {dmg} damage!!");
                Console.ForegroundColor = ConsoleColor.Gray;

            }
            return target.health;
        }
        public int Wait(Enemy target)
        {
            int dmg = this.Strength * 5;
            target.health = target.health - dmg;
            if (target.health <= 0){
                target.health = 0;
                System.Console.WriteLine($"{target.Name} took fatal damage!!! Health is {target.health}");
            }
            else {
                System.Console.WriteLine($"{this.Name} attacked {target.Name} for {dmg} damage!!");
            }
            return target.health;
        }

    }

}
