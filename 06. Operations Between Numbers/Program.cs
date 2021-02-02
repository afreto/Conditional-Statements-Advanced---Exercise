using System;

namespace _06._Operations_Between_Numbers
{
    class Program
    {
        static void Main()
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();
            string oddOrEven;
            double sum = 0;
            switch (symbol)
            {
                case "+":
                case "-":
                case "*":
                    switch (symbol)
                    {
                        case "+":
                            sum = num1 + num2;
                            break;
                        case "-":
                            sum = num1 - num2;
                            break;
                        case "*":
                            sum = num1 * num2;
                            break;
                    }
                    if (sum % 2 == 0)
                    {
                        oddOrEven = "even";
                    }
                    else
                    {
                        oddOrEven = "odd";
                    }
                    Console.WriteLine($"{num1} {symbol} {num2} = {sum} - {oddOrEven}");
                    break;
                case "%":
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    else
                    {
                        switch (symbol)
                        {
                            case "%":
                                sum = num1 % num2;
                                Console.WriteLine($"{num1} {symbol} {num2} = {sum}");
                                break;
                            case "/":
                                sum = num1 / num2;
                                Console.WriteLine($"{num1} {symbol} {num2} = {sum:f2}");
                                break;
                        }
                    }
                    break; 
            }
        }
    }
}
