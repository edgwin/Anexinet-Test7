using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a function that swaps two integers without using a temporary variable.");
            Console.WriteLine("Enter x value");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y value");
            int y = Convert.ToInt32(Console.ReadLine());
            var message = string.Empty;
            if (validate(x, y, out message))
                Console.WriteLine(message);
            else
            {
                x = x * y;
                y = x / y;
                x = x / y;
                Console.WriteLine($"x: {x}");
                Console.WriteLine($"y: {y}");
            }
            Console.ReadLine();
        }

        private static bool validate(int x, int y, out string message)
        {
            message = string.Empty;
            if (x == 0)
                message += "X value can't be zero\n";
            if (y == 0)
                message += "Y value can't be zero";
            return message != string.Empty;
        }
    }
}
