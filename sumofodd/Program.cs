using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumofodd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;
          
            Console.Write("Display the sum of n odd natural number:\n");
            Console.Write("------------------------------------------");

            Console.Write("\nInput number of terms :\n ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("The odd numbers are :");
            for (i = 1; i <= n; i++)
            {
                Console.Write("{0} ", 2 * i - 1);
                sum += 2 * i - 1;
            }
            Console.Write("The Sum of odd Natural Number upto {0} terms : {1}\n", n, sum);
        }
    }
}
