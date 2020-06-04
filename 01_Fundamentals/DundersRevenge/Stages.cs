using System;

namespace DundersRevenge
{
    class Stages
    {
        public static int stage(int stagelvl, Human dunder){
            if (stagelvl == 0){
                StrengthBoss boss = new StrengthBoss("Corona Zombie");
                
                Console.ForegroundColor = ConsoleColor.Cyan;
                System.Console.WriteLine($"You have encountered {boss.Name}");
                Console.ForegroundColor = ConsoleColor.Gray;
                while (boss.health > 0) {
                    dunder.Input(boss);
                    boss.Attack(dunder);
                }
                return 1;
            }
            else if (stagelvl == 1){
                IntelligenceBoss boss = new IntelligenceBoss("Thomas");
                Console.ForegroundColor = ConsoleColor.Cyan;
                System.Console.WriteLine($"You have encountered {boss.Name}");
                Console.ForegroundColor = ConsoleColor.Gray;
                while (boss.health > 0) {
                    dunder.Input(boss);
                }
                return 2;
            }
            else { return 0; }
        }
    }
}
