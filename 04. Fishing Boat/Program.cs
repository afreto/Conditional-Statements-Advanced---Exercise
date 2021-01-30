﻿using System;

namespace _04._Fishing_Boat
{
    class Program
    {
        static void Main()
        {

            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numOfFishermen = int.Parse(Console.ReadLine());
            double discount = 0;
            int rent = 0;

            switch (season)
            {
                case "Spring":
                    rent = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    rent = 4200;
                    break;
                case "Winter":
                    rent = 2600;
                    break;
            }
            if (numOfFishermen <= 6)
            {
                discount = rent * 0.10;
            }
            else if (numOfFishermen >= 7 && numOfFishermen <= 11)
            {
                discount = rent * 0.15;
            }
            else if (numOfFishermen >=12)
            {
                discount = rent * 0.25;
            }

            double totalSum = rent - discount;

            if (numOfFishermen % 2 == 0 && season != "Autumn")
            {
                totalSum -= totalSum * 0.05;
            }
            if (budget >= totalSum)
            {
                Console.WriteLine($"Yes! You have {(budget - totalSum):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(totalSum - budget):f2} leva.");
            }


        }
    }
}
