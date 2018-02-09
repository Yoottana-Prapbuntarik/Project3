using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project3_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double N, Result = 0 ;
          
            Console.Write("Input N :");

            N = double.Parse(Console.ReadLine());
            Result = Math.Round(N);
            if(N == Result)
            {
                Console.Write("{0} is integer",N);
            }
            else
            {
                Console.Write("{0} is not integer  ", N);
            }
            

            Console.ReadLine();
        }
    }
}
