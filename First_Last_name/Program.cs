﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Last_name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your First Name");
            String FirstName = Console.ReadLine();

            Console.WriteLine("Enter your Last Name");
            String LastName = Console.ReadLine();

            Console.WriteLine("Hello {0}, {1}", FirstName, LastName);
        }
    }
}
