using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project3_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string A, B; int RESULT;
            int i = 1;
            while(i != 0) { 
            Console.Write("Please input A: ");
            A = Console.ReadLine();
            Console.Write("Please input B: ");
            B = Console.ReadLine();
            RESULT = string.Compare(A, B);
            if (RESULT == 0)
                Console.WriteLine("A occurs in the same position as B in the sort order.");
            else if (RESULT > 0) Console.WriteLine("A follows B in the sort order.");
            else
                Console.WriteLine("A precedes B in the sort order.");
            }
            Console.ReadLine();
        }
    }
}
