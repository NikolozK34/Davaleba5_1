using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Davaleba5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ricxvi: ");
            int n = int.Parse(Console.ReadLine());

            int mainN = n;
            int reverseN = 0;

            while (n > 0)
            {
                int digit = n % 10;
                reverseN = reverseN * 10 + digit;
                n /= 10;
            }

            bool isPalindrome = mainN == reverseN;

            if (isPalindrome)
            {
                Console.WriteLine($"{mainN} - palindromia.");
            }
            else
            {
                Console.WriteLine($"{mainN} - ar aris palindromi");
            }
        }
    }
}
