using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double Price , Discount;
            char member;
            string Getstring;
            Console.WriteLine("Please input your item’s price :");
            Price = double.Parse(Console.ReadLine());
            Console.WriteLine("Are you may member? : y or n");
            Getstring = Console.ReadLine();
            member = char.Parse(Getstring);
            if(member != 'y')
            {
                Console.WriteLine("Your discount is 0 bath");
                Console.WriteLine("Your price is {0}. Thank you. ", Price);
                

            }
            else if(member == 'y' )
            {
                Discount = (Price * 10) / 100;
                Price = (Price - Discount);
                Console.WriteLine("Your discount is {0} bath",Discount);
                Console.WriteLine("Your price is {0}. Thank you. ", Price);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            Console.ReadLine();
        }
    }
}
