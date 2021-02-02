using System;

namespace _03._New_House
{
    class Program
    {
        static void Main()
        { 
            string flower = Console.ReadLine();
            int numOfFlower = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double flowerPrice = 0;
            switch (flower)
            {
                case "Roses":
                    flowerPrice = numOfFlower * 5;
                    if (numOfFlower > 80)
                    {
                        flowerPrice -= (flowerPrice * 0.10);
                    }
                    break;
                case "Dahlias":
                    flowerPrice = numOfFlower * 3.80;
                    if (numOfFlower > 90)
                    {
                        flowerPrice -= (flowerPrice * 0.15);
                    }
                    break;
                case "Tulips":
                    flowerPrice = numOfFlower * 2.80;
                    if (numOfFlower > 80)
                    {
                        flowerPrice -= (flowerPrice * 0.15);
                    }
                    break;
                case "Narcissus":
                    flowerPrice = numOfFlower * 3;
                    if (numOfFlower < 120)
                    {
                        flowerPrice += (flowerPrice * 0.15);
                    }
                    break;
                case "Gladiolus":
                    flowerPrice = numOfFlower * 2.50;
                    if (numOfFlower < 80)
                    {
                        flowerPrice += (flowerPrice * 0.20);
                    }
                    break;
            }

            if (budget >= flowerPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {numOfFlower} {flower} and {(budget - flowerPrice):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {(flowerPrice - budget):f2} leva more.");
            }
        }
    }
}
