using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
//What is the 10001st prime number?


namespace Kata007_10001stPrime
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> primeNumbers = new List<int>();
            int i = 2;

            while (primeNumbers.Count <= 10000)
            {
                bool tmpIsPrime = CheckPrime(i);
                if (tmpIsPrime == false)
                {
                    primeNumbers.Add(i);
                }
                i = i + 1;
            }

            var lastItem = primeNumbers.Last();
            Console.WriteLine("Die " + primeNumbers.Count + " Primzahl ist: " + primeNumbers.Last());
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
