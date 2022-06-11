using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    public class CouponNumber
    {
        public static void Number()
        {
            int v = 1, i = 0;
            
            Console.WriteLine("Enter the Number to generate random number from it's own length");
                int n = Convert.ToInt32(Console.ReadLine());
            int x = n.ToString().Length;
            while (v == 0)
            {

                 v= n / 10;

                i++;
            }
            int[] arr=new int[i];
        }
    }
}
