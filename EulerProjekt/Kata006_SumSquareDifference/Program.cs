using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//The sum of the squares of the first ten natural numbers is,
//12 + 22 + ... + 102 = 385
//The square of the sum of the first ten natural numbers is,
//(1 + 2 + ... + 10)2 = 552 = 3025
//Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
//Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.

namespace Kata006_SumSquareDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            double ergebnisSumSquares = 0;
            double tmpSumSquares;

            for (int i = 1; i <= 100; i++)
            {
                tmpSumSquares = Math.Pow(i, 2);
                ergebnisSumSquares = ergebnisSumSquares + tmpSumSquares;
            }

            double ergebnisSquareSum = 0;
            double tmpSquareSum = 0;
            for (int y = 1; y <= 100; y++)
            {
                tmpSquareSum = tmpSquareSum + y;
            }

            ergebnisSquareSum = Math.Pow(tmpSquareSum, 2);

            double result = ergebnisSquareSum - ergebnisSumSquares;

            Console.WriteLine("Ergebnis: " + result);
            Console.Read();
        }
    }
}
