using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project3_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x; Console.Write("x = ");
            x = int.Parse(Console.ReadLine());
            if (x >= 0)
            {
                if (x <= 8)
                    Console.WriteLine("A");
            }
            else
                Console.WriteLine("B");
            Console.ReadLine();
        }
    }

}
