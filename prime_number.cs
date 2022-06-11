using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    public class prime_number
    {
        public static void prime()
        {
            int a = 0, b = 0, ctr;
            Console.WriteLine("Enter the number range:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            for (int i = a; i < b; i++) {
               
                int j = 2;
                ctr = 0;

                    while(j<=(i/2)) {
                    
                        if (i % j == 0)
                        {
                        ctr = 1;
                        break;
                        }
                    j++;
                    }
                if (ctr == 0)
                {
                    Console.WriteLine(i + " is a Prime Number");
                }
        }
       }
    }

}
