using System;

namespace DundersRevenge
{
    class Enemy
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        public int health;
        public int Health
        {
            get { return health; }
        }
        public long Barrier;
        

        public Enemy(string name){
            this.Name = name;
            this.Strength = 99;
            this.Intelligence = 99;
            this.Dexterity = 99;
            this.health = 1000;
            this.Barrier = 0;
        }
    }
    class StrengthBoss : Enemy
    {
        public StrengthBoss(string name) : base(name) {
            this.Strength = 400;
            this.health = 9999;
        }

        public void Attack(Human target) {
            Random rand = new Random();
            int roll = rand.Next(0,20);
            if (roll <= 1) {
                int dmg = 20 * this.Strength;
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine($"{this.Name} used ultimate attack 'Kimbo Slice'");
                System.Console.WriteLine($"A devastating attack! {target.Name} took {dmg} damage!");
                Console.ForegroundColor = ConsoleColor.Gray;
                if (target.Barrier <= 0){
                    target.health = target.health - dmg;
                }
                else {
                    target.barrier = target.barrier - dmg;
                }

            }
            else if (roll > 1 && roll <= 9) {
                int dmg = 40;
                Console.ForegroundColor = ConsoleColor.Yellow;
                System.Console.WriteLine($"{this.Name} tripped over a rock taking {dmg}");
                Console.ForegroundColor = ConsoleColor.Gray;
                if (target.Barrier <= 0){
                    target.health = target.health - dmg;
                }
                else {
                    target.barrier = target.barrier - dmg;
                }

            }
            else if (roll > 9) {
                int dmg = 1 * this.Strength;
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine($"{this.Name} used Putrid Punch");
                System.Console.WriteLine($"{target.Name} took {dmg} damage!");
                Console.ForegroundColor = ConsoleColor.Gray;
                if (target.Barrier <= 0){
                    target.health = target.health - dmg;
                }
                else {
                    target.barrier = target.barrier - dmg;
                };
            }
        }
    }
    class IntelligenceBoss : Enemy
    {
        
        public IntelligenceBoss(string name) : base(name) {
            this.Intelligence = 99999;
            this.Barrier = 99999999999999;
            this.health = 2;
        }

        public void Attack(Human target) {
            Random rand = new Random();
            int roll = rand.Next(0,20);
            if (roll <= 1) {
                int dmg = 20 * this.Strength;
                System.Console.WriteLine($"{this.Name} used ultimate attack 'Kimbo Slice'");
                System.Console.WriteLine($"A devastating attack! {target.Name} took {dmg} damage!");
            }
            else if (roll > 1 && roll <= 9) {
                int dmg = 40;
                System.Console.WriteLine($"{this.Name} tripped over a rock taking {dmg}");
            }
            else if (roll > 9) {
                int dmg = 1 * this.Strength;
                System.Console.WriteLine($"{this.Name} used ultimate attack 'Kimbo Slice'");
                System.Console.WriteLine($"A devastating attack! {target.Name} took {dmg} damage!");
            }
            
        }
    }
}
