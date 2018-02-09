using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project3_10
{
    class Program
    {
        static void Main(string[] args)
        {
            char  ch ;

      
            Console.WriteLine("Input Char : ");

            ch = char.Parse(Console.ReadLine());

           
           


            if ((ch >= 'A') && (ch <= 'Z'))
            {
                Console.WriteLine("Upper case letter. ");
            }
            else if ((ch >= 'a') && (ch <= 'z'))
            {
                Console.WriteLine("Lower case letter.");

            }
            else if ( ch >= '1')
            {
                Console.WriteLine("Degit.");
            }

            else
            {
                Console.WriteLine("Other.");
            }
           
            
                
           
            
            Console.ReadLine();
            
        }
    }
}
