﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charactercompare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Enter the first character : ");
            char c1 = Console.ReadLine()[0];

            Console.WriteLine("Enter the second character : ");
            char c2 = Console.ReadLine()[0];

            if (c1 == c2)
                Console.WriteLine("Both characters are equal");
            else
                Console.WriteLine("Characters are not equal");
        }
    }
}
