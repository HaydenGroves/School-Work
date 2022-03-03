using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FineTuning
{
    class CharChoice
    {
        
        public static void character()
        {
            int answer;  // This variable has been created to be used throughout the module as it is used to store the user inut multiple times.
            Console.WriteLine("Please enter your name.");
            Character.Name = Console.ReadLine(); // This line is used to store the user's name once entered, which is then referenced elsewhere in the program. 

            Console.WriteLine("Prepare to enter your stats. you have 10 points to put into HP, Base Damage and Speed.");
            int StatPoints = 10; // This variable has been used here as it acts as a limit for what the user can input. When this value raches 0 the user can no longer add any more points to their character.
            start: // I have chosen to use a goto statement so that if the user has any points left after going through the stats once, they would have to go through the cycle again until they have used all of their points.
            HP:
            Console.WriteLine("How many points would you like to put into HP: 1 point = 10 HP.");
            answer = Convert.ToInt32(Console.ReadLine());

            if (answer >= 1) // I have chosen to use this IF statement here to determine if the user has inputed a value equal to or greater than 1. if the user has, it would procede with the block of code, otherwise it would go to the next section.
            {
                if (answer > StatPoints)
                {
                    Console.WriteLine("you do not have enough statpoints.");
                    goto HP;
                }
                Character.HP = Character.HP + answer * 10; // I have chosen to use the answer the user gives as a baseline for calculating stat increases. here 1 "Stat Point" - 10HP, which would get added onto their character's total HP.
                Console.WriteLine("you added " + answer * 10 + " to your current health pool.");
                StatPoints = StatPoints - answer; // The reason for this line is to take away used statpoints from the total. as stated before, this is to limite the user's selection of stats.
                Console.WriteLine("you have " + StatPoints + " left");
            }
            if (StatPoints == 0) // This if statement is used to check if the user has 0 statpoints left before the end. if they do, it skips down to the bottom of the code where it displays the user's stats.
            {
                goto end;
            }

        damage:
            Console.WriteLine("how many points would you like to put int your base damage? 1 point adds 1 damage.");
            answer = Convert.ToInt32(Console.ReadLine());

            if (answer >= 1) // This IF statement is the same as the last, wherein if the user enters a value equal to or greater than 1, they add the answer to their stats, if they input 0, they move onto the next IF statement. 
            {
                if (answer > StatPoints) // The reason for this if statement is to check whether or not the user has enough statpoints left. this is to prevent statpoints that don't exist from being used.  
                {
                    Console.WriteLine("you do not have enough statpoints.");
                    goto damage;
                }
                Character.BaseDamage = Character.BaseDamage + answer;
                Console.WriteLine("you added " + answer + " to your base damage.");
                StatPoints = StatPoints - answer;
                Console.WriteLine("you have " + StatPoints + " left");
            }
            if (StatPoints == 0)
            {
                goto end;
            }

        Speed:
            Console.WriteLine("how many points do you want to put into your base speed? 1 point adds 1 speed.");
            answer = Convert.ToInt32(Console.ReadLine());

            if (answer >= 1)
            {
                if (answer > StatPoints)
                {
                    Console.WriteLine("you do not have enough statpoints.");
                    goto Speed;
                }
                Character.Speed = Character.Speed + answer;
                Console.WriteLine("you added " + answer + " to your speed.");
                StatPoints = StatPoints - answer;
                Console.WriteLine("you have " + StatPoints + " left");
            }

            if (StatPoints > 0) // I used this IF statement to determine whether or not all the stat points are used.
            {
                Console.WriteLine("You need to spend all of your points.");
                goto start; // This is the goto statement that jumps back to the start: marker if the user has not spent all of their stat points. 
            }
           
            
             // After all of the stat points have been spent, the character's "stat sheet" is generated. this information is used when fighting the enemy.
              end:  
                Console.WriteLine("Hello " + Character.Name + ". Your stats are: ");
                Console.WriteLine(Character.HP + " HP");
                Console.WriteLine(Character.BaseDamage + " Base Damage");
                Console.WriteLine(Character.Speed + " Base Speed");
                Console.ReadLine();
            

        }
    }
    class Character
    { // The reason why all of these variables are public is because they are used in different modules and by having them all static, they can change their value easily jsut by being referenced. 
        public static int HP = 100;
        public static int BaseDamage = 2;
        public static int Speed = 4;
        public static string Name;
    }
}

