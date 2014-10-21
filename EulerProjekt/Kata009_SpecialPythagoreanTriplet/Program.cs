using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
//a^2 + b^2 = c^2
//For example, 32 + 42 = 9 + 16 = 25 = 52.
//There exists exactly one Pythagorean triplet for which a + b + c = 1000.
//Find the product abc.

namespace Kata009_SpecialPythagoreanTriplet
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int sum = 1000;
            int product = 0;
            for (int a = 1; a <= (1000 / 3); a++)
            {
                for (int b = a + 1; b <= (1000 / 2); b++)
                {
                    int c = sum - a - b;
                    if (a * a + b * b == c * c)
                    {
                        Console.WriteLine("Zahl a: " + a + " Zahl b: " + b + " Zahl c: " + c);
                        product = a * b * c;
                    }
                }
            }
            Console.WriteLine("Produkt: " + product);
            Console.Read();
        }
    }
}
