using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1task2
{
    class Program
    {
          delegate int Delegate();
        static void Main(string[] args)
        {
            Delegate[] delegates = new Delegate[10];

            for (int x = 0; x < 10; x++)
            {
                delegates[x] = delegate
                {
                    Random rndm = new Random();
                    return rndm.Next(1, 100);
                };
            }

            Func<Delegate[], double> average = delegate (Delegate[] arr)
            {
                double sum = 0;
                foreach (Delegate del in arr)
                {
                    sum += del();
                }
                return sum / arr.Length;
            };

            Console.WriteLine("Аverage: " + average(delegates));

            Console.ReadLine();
        }
    }
}