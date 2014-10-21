using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
//Find the sum of all the multiples of 3 or 5 below 1000.
//Answer: 233168

namespace Kata_MultiplesOf3And5
{
    class Program
    {
        static void Main(string[] args)
        {
            int Result = 0;
            for (int i = 1; i < 1000; i++)
            {
                int modDrei = i % 3;
                int modFive = i % 5;

                if (modDrei == 0 || modFive == 0)
                {
                    Console.WriteLine(i);
                    Result = Result + i;
                }
            }
            Console.WriteLine(Result);
            Console.Read();
        }
    }
}