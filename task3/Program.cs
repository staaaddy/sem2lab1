using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Diagnostics;

namespace lab1task3 

{
    internal class Program
    {
        delegate int Operation(int a, int b, int c);

        static void Main(string[] args)
        {
            Operation average = delegate (int a, int b, int c)
            {
                return (a + b + c) / 3;
            };

            Console.WriteLine("Value a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Value b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Value c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Average: " + average(a, b, c));

            Console.ReadLine();
        }

    }
}
