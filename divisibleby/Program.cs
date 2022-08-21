using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divisibleby
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, sum = 0;
                       
            for (i = 100; i <= 200; i++)
            {            
                Console.Write("{0}  ", i);
                    sum += i;
                    
                
            }
            Console.Write("\n\nThe sum : {0} \n", sum);
        }
    }
}
