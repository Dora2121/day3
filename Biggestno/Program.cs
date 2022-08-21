using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biggestno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Enter a value");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b value");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("{0} is Biggest number", +a);
            }
            else 
            {
                Console.WriteLine("{1} is Biggest number", +b);
            }
        }
    }
}
