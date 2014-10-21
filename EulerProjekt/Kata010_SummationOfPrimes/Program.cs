using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
//Find the sum of all the primes below two million.

namespace Kata010_SummationOfPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> primeNumbers = new List<int>() { 0 };
            int i = 2;
            int primeCount = 2000000;
            while (i <= primeCount)
            {
                bool tmpIsPrime = CheckPrime(i);
                if (tmpIsPrime == false)
                {
                    primeNumbers.Add(i);
                }
                i = i + 1;
                Console.WriteLine("Ich rechne noch " + i);
            }

            double sumOfPrimes = 0;
            for (int j = 0; j <= primeNumbers.Count - 1; j++)
            {
                if (primeNumbers[j] <= primeCount)
                {
                    sumOfPrimes = sumOfPrimes + primeNumbers[j];
                }
            }

            Console.WriteLine("Summe aller Primzahlen bis: " + primeCount + " = " + sumOfPrimes);
            Console.Read();
        }

        static bool CheckPrime(int Number)
        {
            for (int i = 2; i <= Number - 1; i++)
            {
                if (Number % i == 0) return true;
            }
            return false;
        }
    }
}
