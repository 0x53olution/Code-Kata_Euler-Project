using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//The prime factors of 13195 are 5, 7, 13 and 29.
//What is the largest prime factor of the number 600851475143 ?

namespace Kata003_LargestPrimeFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            double testNumber = 600851475143;
            //allPrimes(testNumber);

            for (int i = 3; i <= Math.Sqrt(testNumber); i += 2)
            {
                if (testNumber % i == 0 && isprime(i) == 1)
                    Console.WriteLine(i);
            }

            Console.ReadLine();
        }

        static int isprime(double p)
        {
            if (p % 2 == 0) return 0;

            for (int i = 3; i <= Math.Sqrt(p); i += 2)
                if (p % i == 0)
                    return 0;

            return 1;
        }

        public static void allPrimes(double value)
        {
            for (double i = 2; i <= value; i++)
            {
                Boolean isPrime = true;
                for (double j = 2; j < i && isPrime; j++)
                {
                    if ((i % j) == 0)
                    {
                        isPrime = false;
                    }
                }
                if (isPrime == true)
                {
                    Console.WriteLine(i + " ist eine Primzahl");
                }
            }
        }
    }
}

