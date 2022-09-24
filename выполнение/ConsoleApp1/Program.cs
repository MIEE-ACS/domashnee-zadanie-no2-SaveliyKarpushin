//Вариант 7 Карпушин Савелий УТС-21
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите R(на графике R=3): ");
            double R = double.Parse(Console.ReadLine());


            double y;

            for (double x = -7; x < 90; x += 0.2)
            {


                if (x >= -7 && x <= -3)
                {
                    y = 3;
                    Console.Write($"y:{y:0.00}\n");

                }
                else
                if (x > -3 && x <= 3)
                {
                    y = 3 - Math.Sqrt(R * R - x * x);
                    Console.Write($"y:{y:0.00}\n");
                }
                else
                    if (x > 3 && x <= 6)
                {
                    y = 9 - 2 * x;
                    Console.Write($"y:{y:0.00}\n");
                }
                else
                    if (x > 6 && x <= 11)
                {
                    y = x - 9;
                    Console.Write($"y:{y:0.00}\n");
                }
            }
        }
    }
}
