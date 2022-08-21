using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace stringcomp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the str1:");
            string str1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the str2:");
            string str2 = Convert.ToString(Console.ReadLine());

            
            Console.WriteLine(str1 == str2);
        }
       
    }
}
