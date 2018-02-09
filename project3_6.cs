using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 1, y = 2, z = 3;
            y = double.Parse(Console.ReadLine());

            if ((y >= 0) && (y < 0.5))
                Console.WriteLine("A");
            else if ((y >= 0.5) && (y < 1))
                Console.WriteLine("B");
            else
                Console.WriteLine("C");
            Console.ReadLine();
        }
    }
}
