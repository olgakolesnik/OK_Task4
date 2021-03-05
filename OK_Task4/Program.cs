using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OK_Task4
{
    class Program
    {
        public static bool IsPalindrome(string str)
        {
            int i = 0, j = str.Length - 1;

            while (i < j)
                if (str[i++] != str[j--]) return false;

            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input word: ");
            
            String str = Console.ReadLine();

            if (IsPalindrome(str) == true) Console.WriteLine("Word is a palindrome");
            else Console.WriteLine("World is not a palindrome");
           
            Console.ReadKey();
        }
    }
}
