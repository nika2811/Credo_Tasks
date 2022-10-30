using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials
{
    class Program
    {
        static char target = 'e';

        static void Main(string[] args)
        {
            char[] charArray = { 'a', 'e', 'i', 'o', 'u', 'ა', 'ე', 'ი', 'ო', 'უ' };

            var check = Array.Exists(charArray, IsVowel);
            if (check == true)
            {
                Console.WriteLine("{0} found in the array", target);
            }
            else
            {
                Console.WriteLine("Value not found");
            }
        }

       
        public static bool IsVowel(char x)
        {
            return x == target;
        }
    }
}