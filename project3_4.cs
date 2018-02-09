using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int first, second, third;
            Console.Write("Please enter 1st number: ");
            first = int.Parse(Console.ReadLine());

            Console.Write("Please enter 2nd number: ");
            second = int.Parse(Console.ReadLine());

            Console.Write("Please enter 3rd number: ");
            third = int.Parse(Console.ReadLine());

            if (first > second)
            {
                if (second > third)
                    Console.WriteLine("1st number is the greatest.");
                else if (first > third)
                    Console.WriteLine("1st number is the greatest.");
                else
                    Console.WriteLine("3rd number is the greatest.");
            }
            else if (second > third)
                Console.WriteLine("2nd number is the greatest.");
            else
                Console.WriteLine("3rd number is the greatest");
            Console.ReadLine();
         
        }
    }
}
