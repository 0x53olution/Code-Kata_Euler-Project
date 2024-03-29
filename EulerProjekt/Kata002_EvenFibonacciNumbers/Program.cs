﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:
//1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
//By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.

namespace Kata002_EvenFibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int anzahl = 35;
            long result = 0;
            long[] fibonacciReihe = new long[anzahl];

            for (int n = 1; n < anzahl; n++)
            {
                if (n < 2)
                {
                    fibonacciReihe[n] = 1;
                    //Console.WriteLine("n = " + n + " f= " + fibonacciReihe[n]);
                }
                else
                {
                    fibonacciReihe[n] = fibonacciReihe[n - 1] + fibonacciReihe[n - 2];
                    //Console.WriteLine("n = " + n + " f= " + fibonacciReihe[n]);
                }
            }
            for (int j = 0; j < fibonacciReihe.Length; j++)
            {
                Console.WriteLine(fibonacciReihe[j]);
                if (meinTest(fibonacciReihe[j]))
                {
                    result = result + fibonacciReihe[j];
                }

            }
            Console.WriteLine("Summe = " + result);
            Console.Read();
        }

        static Boolean meinTest(long value)
        {
            return value % 2 == 0;
        }
    }
}
