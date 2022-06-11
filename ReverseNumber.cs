using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    public class ReverseNumber
    {
        public static void reverse()
        {
            int rev=0, temp;
            Console.WriteLine("Enter a Number; ");
            int num=Convert.ToInt32(Console.ReadLine());

            while (num != 0)
            {
                temp = num % 10;
                num = num / 10;
                rev = rev * 10 + temp;

            }
            Console.WriteLine("The reverse of number is: " + rev);
        }
    }

}
