using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    public class Fibonacci
    { public static void fib() //0, 1. 1, 2, 3, 5, 8
        {

            int previous=0, next=1, temp;
            Console.WriteLine("Enter the number of terms to be printed: ");
            int n= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(0);
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(next);
                temp = next;
                next = next + previous;
                previous = temp;
                
                
                
            }
        }
    }
}
