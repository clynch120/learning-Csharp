/*Charels Lynch
My first C# program

This program checkes to see if 
your lucky number matchs the computer number*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int new1 = r.Next(30);
            int new2 = r.Next(30);
            int big = add(new1, new2);
            Console.WriteLine(speak());
            int userNum = favNum();
            if (userNum == big)
            {
                Console.WriteLine("Yes !!!! " + big + " we have the same favorit number!");
            }
            else
            {
                Console.WriteLine("\n" + big + " is my favorit number");
                Console.WriteLine("To bad we don't have the same favorit number :(");
            }
           
            Console.Write("Press enter to continue: ");
            Console.ReadLine();
            Console.ReadLine();
        }
        static int add(int one, int two)
        {
            int newint = one + two;
            return newint;
        }
        static String speak ()
        {
            
            Console.Write("Hello! What is your name ? ");
            String name = Console.ReadLine();
            Console.Write("Hi " + name + ", How are you feeling ? ");
            String feel = Console.ReadLine();
            return "\nYour name is " + name + " and you feel " + feel + "!\n" ;
        }

        static int favNum()
        {
            Console.Write("What is your favorit number? ");
            int favoritNum = Console.Read();
            return favoritNum;
        }
    }
}
