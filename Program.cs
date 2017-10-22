using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
       {
            string Number = Console.ReadLine();
            string ReversedDigits = ReverseTheDigits(Number);
            Console.WriteLine(RemoveZeros(ReversedDigits));
       }

        public static void ReverseTheDigits(Number)
        {
            char[] CharDigit = Digit.ToCharArray();
            string ReversedString = null;
            int a = 0;
            if (CharDigit[0] == '-')
            {
                a = 1;
                ReversedString += CharDigit[0];
            }
        }


    }
}
