using System;

namespace _01._Cinema
{
    class Program
    {
        static void Main()
        {
            string type = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double ticketPrice = 0;

            switch (type)
            {
                case "Premiere":
                    ticketPrice = 12;
                    break;
                case "Normal":
                    ticketPrice = 7.50;
                    break;
                case "Discount":
                    ticketPrice = 5.00;
                    break;
            }

            double sum = (r * c) * ticketPrice;
            Console.WriteLine($"{sum:f2} leva");

        }
    }
}
