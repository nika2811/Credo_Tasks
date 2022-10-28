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
            int[] array =  { 0, 1, 5, 76, 234, 678 };
            int target = 76;
            int result = binarySearch(array, target);
            if(result == -1)
            {
                Console.WriteLine("Element not Found");
            }
            else
            {
                Console.WriteLine("Element Found at index " + result);
            }

        }

        public static  int binarySearch(int[] arr,int x)
        {
            int l = 0;
            int r = arr.Length - 1;
            while (l <= r)
            {
                int medium = l + (r - l) / 2;
                
                if (arr[medium] == x)
                {
                    return medium;
                }
                if (arr[medium] < x)
                {
                    l = medium + 1;
                }
                else
                {
                    r = medium - 1;
                }
            }
            return -1;
        }
    }
}