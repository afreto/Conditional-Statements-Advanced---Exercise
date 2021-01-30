﻿using System;

namespace _05._Journey
{
    class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            string where = "";
            double spendMoney = 0;
            if (budget <= 100)
            {
                destination = "Bulgaria";
                switch (season)
                {
                    case "summer":
                        spendMoney = budget * 0.30;
                        break;
                    case "winter":
                        spendMoney = budget * 0.70;
                        break;
                }
            }
            else if (budget <= 1000 && budget > 100)
            {
                destination = "Balkans";
                switch (season)
                {
                    case "summer":
                        spendMoney = budget * 0.40;
                        break;
                    case "winter":
                        spendMoney = budget * 0.80;
                        break;
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                spendMoney = budget * 0.90;
            }
            switch (destination)
            {
                case "Europe":
                    where = "Hotel";
                    break;
                default:
                    switch (season)
                    {
                        case "summer":
                            where = "Camp";
                            break;
                        case "winter":
                            where = "Hotel";
                            break;
                    }
                    break;
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{where} - {spendMoney:f2}");
        }
    }
}

