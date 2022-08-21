using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace largestof3num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b value:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter c value:");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("A is the Largest");
            }
             else if (b > c)
            {
                Console.WriteLine("B is the Largest");
            }
            else
            {
                Console.WriteLine("C is the Largest");
            }

            Console.ReadLine();
        }
    }
}
