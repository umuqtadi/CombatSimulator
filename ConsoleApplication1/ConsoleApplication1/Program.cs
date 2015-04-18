﻿using System;
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
        static string userChoice = Console.ReadLine();

        static void Main(string[] args)
        {
            Console.WriteLine("I hope you are ready for an adventure. You have just learned that you come from a long lineage of Dragon Slayers. To prove your value you must fight a dragon.");
            Console.WriteLine("\nYou will have three options when fighting this majestic beast. \n1. Use your sword. It will cause 20-35 damage, but will only hit 70% of the time \n2. You can use your magic and it will always hit the dragon, but will only cause damage between 10-15. \n3. Your last option is to heal. This will improve your health anywhere \nfrom 10-20 hp, but you can still be hit by the dragon.");

            while (playerHP >0 && dragonHP >0)
            {
                Console.WriteLine("I hope you are ready for an adventure. You have just learned that you come from a long lineage of Dragon Slayers. To prove your value you must fight a dragon.");
                Console.WriteLine("\nYou will have three options when fighting this majestic beast. \n1. Use your sword. It will cause 20-35 damage, but will only hit 70% of the time \n2. You can use your magic and it will always hit the dragon, but will only cause damage between 10-15. \n3. Your last option is to heal. This will improve your health anywhere \nfrom 10-20 hp, but you can still be hit by the dragon.");

            }

            Console.ReadKey();
        }
        static void UserOptions()
        {
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                dragonHP = dragonHP - (rng.Next(20,36));
            }
            if (userChoice == "2")
            {
                dragonHP = dragonHP - (rng.Next(10, 16));
            }
            if (userChoice == "3")
            {
                playerHP = playerHP + (rng.Next(10, 21));
            }
        }
        static void DragonAttack()
        {
            playerHP = playerHP - rng.Next(5, 16);
        }
        static void WinOrLose()
        {
            if (playerHP <= 0)
            {
                Console.WriteLine("You have lost the game");
            }
            if (dragonHP <= 0)
            {
                Console.WriteLine("Congratulations! You have killed a mythical creature.");
            }
        }
    }
}