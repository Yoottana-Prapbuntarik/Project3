using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project3_5
{

    class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());
            if (N < 0) { 
            Console.WriteLine("Negative Number");
            }
            else if (N > 0) { 
            Console.WriteLine("Positive Number");
            }
            else
            {
                Console.WriteLine("Zero Number");
            }
            Console.ReadLine();
        }
    }
}


    

