using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int   sum = 0;

           
            Console.Write("Display the number in reverse order:\n");
           
            Console.Write("Enter a number: ");
           int num = Convert.ToInt32(Console.ReadLine());

            for (int t = num; t != 0; t = t / 10)
            {
               int  r = t % 10;
                 sum = sum * 10 + r;
            }
            Console.Write("The number in reverse order is : {0} \n", sum);
        }
    }
}
