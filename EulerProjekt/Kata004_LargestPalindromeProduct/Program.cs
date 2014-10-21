using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
//Find the largest palindrome made from the product of two 3-digit numbers.

namespace Kata004_LargestPalindromeProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            var allProducts = from x in Enumerable.Range(100, 900)
                              from y in Enumerable.Range(100, 900)
                              where x <= y
                              let product = x * y
                              orderby product descending
                              select new { x, y, product };
            var palindrome = (from n in allProducts
                              let chars = n.product.ToString()
                              let reverse = new string(chars.Reverse().ToArray())
                              where chars == reverse
                              select n).First();
            Console.WriteLine("{0}, {1} => {2}", palindrome.x, palindrome.y, palindrome.product);
            Console.ReadLine();
        }

        public static bool IsPalindrome(string value)
        {
            int min = 0;
            int max = value.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = value[min];
                char b = value[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }
    }
}
