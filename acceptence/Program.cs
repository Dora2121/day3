using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acceptence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p, q, r, s;

            Console.WriteLine("Enter the first integer:");
            p=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second integer:");
            q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Third integer:");
            r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the fourth integer:");
            s = Convert.ToInt32(Console.ReadLine());



            if ((q > r) && (s > p) && ((r + s) > (p + q)) && (r!=2) && (s > 0) && (p % 10 == 0))
            {
                Console.WriteLine("\nCorrect values\n"); 
            }
            else
            {
                Console.WriteLine("\nWrong values\n");
            }
        }
    }
}
