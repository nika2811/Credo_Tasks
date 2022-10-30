using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = 565164;

            var Instance = new Program();
            var Bin = Instance.ToBinary(number);

            Console.WriteLine(Bin);
        }

        public string ToBinary(long number)
        {
            string binary = "";
            for (int i = 0; number>0; i++)
            {
                binary += number % 2;
                number = number / 2;
            }
            var reverseBinary = Reverse(binary);
            return reverseBinary; 
        }


        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

    }
}