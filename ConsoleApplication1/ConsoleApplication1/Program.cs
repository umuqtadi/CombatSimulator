using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static int playerHP = 100;
        static int dragonHP = 200;
        static Random rng = new Random();
        static string userChoice = string.Empty;
        static bool gameOn = true;

        static void Main(string[] args)
        {
            //name of game and prompt of the info of what options you have when fighting the dragon
            Console.WriteLine(@"  ___                         ___ _                     ___ ___ 
 |   \ _ _ __ _ __ _ ___ _ _ / __| |__ _ _  _ ___ _ _  / _ \ __|
 | |) | '_/ _` / _` / _ \ ' \\__ \ / _` | || / -_) '_| \_, /__ \
 |___/|_| \__,_\__, \___/_||_|___/_\__,_|\_, \___|_|    /_/|___/
               |___/                     |__/                   

");
            
            Console.WriteLine("I hope you are ready for an adventure. You have just learned that you come from a long lineage of Dragon Slayers. To prove your value you must fight a dragon.");
            Console.WriteLine("\nYou will have three options when fighting this majestic beast. \n1. Use your sword. It will cause 20-35 damage, but will only hit 70% of the time \n2. You can use your magic and it will always hit the dragon, but will only cause damage between 10-15. \n\n3. Your last option is to heal. This will improve your health anywhere \nfrom 10-20 hp, but you can still be hit by the dragon.");



            while (playerHP > 0 && dragonHP > 0)
            {
               
                UserOptions();
                DragonAttack();
                WinOrLose();
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Check if the user input is valid and performs actions based on their entry. Either 1,2 or 3.
        /// </summary>
        static void UserOptions()
        {
            userChoice = Console.ReadLine();

                if (userChoice == "1")
                {
                    //if they choose to use the sword attack it will only hit if 1-7 is generated. 70%
                    int hitAccuracy = rng.Next(0, 11);
                    if (hitAccuracy < 8)
                    {
                        int hpRange = rng.Next(20, 36);
                        dragonHP = dragonHP - hpRange;
                        Console.WriteLine("You hit the dragon for {0} hp", (200 - dragonHP));
                        Console.WriteLine("The dragon now has {0} hp.", dragonHP);
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                    }
                    else if (hitAccuracy > 8)
                    {
                        
                        Console.WriteLine("You missed the dragon. Don't die!");
                    }

                }

                else if (userChoice == "2")
                {
                    //will hit dragon from 10-15 hp 
                    dragonHP = dragonHP - (rng.Next(10, 16));
                    Console.WriteLine("The dragon has {0} hp.", dragonHP);
                    System.Threading.Thread.Sleep(800);
                    Console.Clear();
                }
                else if (userChoice == "3")
                {
                    //will heal the player with a random amount between 10-20
                    playerHP = playerHP + (rng.Next(10, 21));
                    Console.WriteLine("The dragon has {0} hp", dragonHP);
                    System.Threading.Thread.Sleep(800);
                    Console.Clear();
                }
                else
                {
                    //will display when any input rather than 1,2 or 3 is chosen
                    Console.WriteLine("Please enter a valid input, idiot.");
                    Console.WriteLine("You now have {0} hp", playerHP);
                    System.Threading.Thread.Sleep(800);
                    Console.Clear();
                }
        }
        /// <summary>
        /// Will determine the amount of damage the dragon will inflict on you.
        /// </summary>
        static void DragonAttack()
        {
            int fireAcc = rng.Next(0, 11);

            if ("123".Contains(userChoice))
            {
                //only lets the dragon hit if 1-8 is randomly generated
                if (fireAcc < 9)
                {
                    playerHP = playerHP - rng.Next(5, 16);
                    Console.WriteLine("You now have {0} hp", playerHP);
                }
                else
                {
                    Console.WriteLine("The dragon missed. You may just live to see another day");
                    Console.WriteLine("You still have {0}hp", playerHP);
                    System.Threading.Thread.Sleep(1100);
                    Console.Clear();
                }
            }
        }
        /// <summary>
        /// Will tell you who wins or loses. Whoever gets to 0 hp will lose
        /// </summary>
        static void WinOrLose()
        {
            if (playerHP <= 0)
            {
                Console.WriteLine("You have lost the game");
            }
            if (dragonHP <= 0)
            {
                Console.WriteLine("Congratulations! You have killed an endangered mythical creature. Are you proud of yourself?");
            }
        }
    }
}
