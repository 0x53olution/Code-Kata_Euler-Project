using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
//What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?


namespace Kata005_SmallestMultiple
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            bool done = false;
            while (done == false)
            {
                number = number + 1;
                for (int i = 1; i <= 20; i++)
                {
                    int test = number % i;
                    if (number % i == 0)
                    {
                        done = true;
                    }
                    else
                    {
                        done = false;
                        break;
                    }
                }
            }

            Console.WriteLine("Die Zahl " + number + " ist durch die Zahlen von 1 bis 20 teilbar");
            Console.ReadLine();
        }
    }
}
