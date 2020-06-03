using System;


namespace Human
{
    class Human
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
        // add a public "getter" property to access health
        public int Health 
        {
            get { return health; }
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
    }

}
