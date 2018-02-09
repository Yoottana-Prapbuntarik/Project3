using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project3_2
{
    class Program
    {


        static void Main(string[] args)
        {
            String  height ; int convertheight;
            Console.WriteLine("Please input your height :");
            height = Console.ReadLine();
            convertheight = int.Parse(height);

            if (convertheight > 120)
                Console.WriteLine("Your ticket price is 350 baht.");

           else if (convertheight <= 120)
                Console.WriteLine("Your ticket price is 250 baht.");

            Console.ReadLine();
        }
    }
}
