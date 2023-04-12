using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1task1
{
    internal class Program
    {
        delegate float Operation(float x, float y);
        static void Main(string[] args)
        {
            Operation add = (a, b) => a + b;
            Operation sub = (a, b) => a - b;
            Operation mul = (a, b) => a * b;
            Operation div = (a, b) =>
            {
                if (b == 0)
                {
                    Console.WriteLine("Помилка! Неможливо дiлити на 0!");
                    return 0;
                }
                return a / b;
            };
            Console.WriteLine("Яку дiю використати? (+, -, *, /): ");
            string opr = Console.ReadLine();

            Console.WriteLine("Введiть два числа: ");
            float num1 = float.Parse(Console.ReadLine());
            float num2 = float.Parse(Console.ReadLine());
            switch (opr)
            {
                case "+":
                    Console.WriteLine(add(num1, num2));
                    break;
                case "-":
                    Console.WriteLine(sub(num1, num2));
                    break;
                case "*":
                    Console.WriteLine(mul(num1, num2));
                    break;
                case "/":
                    Console.WriteLine(div(num1, num2));
                    break;
                default:
                    Console.WriteLine("Помилка! Неправильна дiя!");
                    break;
            }
            Console.ReadLine();
        }
    }
}