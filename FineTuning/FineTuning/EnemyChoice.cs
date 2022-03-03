using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FineTuning
{
    class EnemyChoice
    {
        
    public static void Enemy()
    {
            Random gen = new Random();

            int Mtype = gen.Next(1, 4);  // Generates a random number between 1 and 4 which decides on the enemy type.

            if (Mtype == 1) // An if statement that would run if the number generated was one.
            {
                EnemyInfo.Name = "Ghoul"; // Assigns the enemy a name.
                EnemyInfo.HP = 100; // Assigns the enemy a base HP value.
                EnemyInfo.Speed = gen.Next(2, 7); // Use RNG to generate a Speed value between a range. 
                EnemyInfo.BaseDamage = 3; // Assigns a base damage value that is added onto the enemy's attack.
                Console.WriteLine("You encountered a " + EnemyInfo.Name);
            }
            else if (Mtype == 2) // This IF statement is run if the number generated is 2. It does this for all of the IF statements depending on the number. 
            { // Each IF statment is used to assign the enemy stats which are the baseline part of the stats. 
                EnemyInfo.Name = "Wraith";
                EnemyInfo.HP = 75;
                EnemyInfo.Speed = gen.Next(4, 8);
                EnemyInfo.BaseDamage = 5;
                Console.WriteLine("You encountered a " + EnemyInfo.Name);
            }
            else if (Mtype == 3)
            {
                EnemyInfo.Name = "Rat";
                EnemyInfo.HP = 45;
                EnemyInfo.Speed = gen.Next(4, 10);
                EnemyInfo.BaseDamage = 2;
                Console.WriteLine("You encountered a " + EnemyInfo.Name);
            }
            else if (Mtype == 4)
            {
                EnemyInfo.Name = "Golem";
                EnemyInfo.HP = 150;
                EnemyInfo.Speed = gen.Next(1, 5);
                EnemyInfo.BaseDamage = 1;
                Console.WriteLine("You encountered a " + EnemyInfo.Name);
            }
        }
    }
    class EnemyInfo
    { // These variables need to be accessed from other modules as they are necessary. for instance when calculating the attack damage of the enemy, it needs the BaseDamage variable. 
        static public int HP;
        static public int BaseDamage;
        static public int Speed;
        static public string Name;
    }
}
