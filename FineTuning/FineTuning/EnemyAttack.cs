using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FineTuning
{
    class EnemyAttack
    {
    public static void Attack()
    {
            Random rnd = new Random(); // This variable is used to initialize the random number generator at the start of the program.
            int attack;
            int ChanceToHit;
            bool Hit = false;
            int violence = rnd.Next(1, 3);

            if (violence == 1) // I have 3 if statements that are used to determine what the enemy does. for instance, if the number generated is 1, the enemy does a default attack.
            {
                attack = rnd.Next(12, 20) + EnemyInfo.BaseDamage; // As with the player damage, the enemy have their damage calculated in the same way, where the damage is random between a range and the base damage is added on afterwards.
                if (PlayerAttack.block == true) // here we can see the variable used in the PlayerAttack Module come into use. if the variable is true then the damage the player takes is reduced, depending on the attack. 
                {
                    attack = attack / 4; // As we can see here where the damage is divided by 4 if the user blocked. 
                }
                Character.HP = Character.HP - attack; // This line is used to calculate the player's HP after the attack. 
                Console.WriteLine("the monster hit you for " + attack + " damage! \n");
                PlayerAttack.block = false; // This would set the player's block variable to false after they have been attacked. this effectively resets the block variable

            }
            else if (violence == 2)
            {
                ChanceToHit = rnd.Next(1, 4);
                if (ChanceToHit == 1)
                {
                    Hit = true;
                }
                if (Hit == true)
                {
                    attack = rnd.Next(15, 30) + EnemyInfo.BaseDamage;
                    if (PlayerAttack.block == true)
                    {
                        attack = attack / 2;
                    }
                    Character.HP = Character.HP - attack;
                    Console.WriteLine("the monster hit you with a heavy attack for " + attack + " damage! \n");
                    PlayerAttack.block = false;
                }
                else
                {
                    Console.WriteLine("the monster missed. \n");
                }
            }
            else if (violence == 3)
            {
                Console.WriteLine("the monster didn't do anything... \n");
            }

            Console.WriteLine("your HP is " + Character.HP + "\n"); // This is the same as the PlayerAttack version, but instead of displaying the Enemy HP it shows the Player HP. this meanas that after both the player and the enemy have attacked both their HP are displayed.
        }
    }
}
