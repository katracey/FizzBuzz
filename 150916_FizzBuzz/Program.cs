using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _150916_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Players generally sit in a circle. The first player says the number “1”, and each player says next number in turn. However, any number divisible by X (for example, three) is replaced by the word fizz, and any divisible by Y (for example, five) by the word buzz. Numbers divisible by both become fizz buzz. A player who hesitates, or makes a mistake is eliminated from the game.
            Write a program that prints out the final series of numbers where those divisible by X, Y and both are replaced by “F” for fizz, “B” for buzz and “FB” for fizz buzz.
            Get user input for the value of X (for fizz), Y (for buzz), and Z (for how high to count).
            */

            /*
            Console.WriteLine("Please provide integers x, y, and z.");
            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y = ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("z = ");
            int z = int.Parse(Console.ReadLine());
            int[] myArray = new int[z];
            */

            //following is for CodeEval set up
            string[] myArray = line.Split(' ');
            int x = int.Parse(myArray[0]);
            int y = int.Parse(myArray[1]);
            int n = int.Parse(myArray[2]);

            //back to core code (without set up)
            int i;


            for (i = 1; i < n; i++)
            {
                if ((i % x == 0) && (i % y == 0))
                {
                    System.Console.WriteLine("FB");
                }
                else if (i % x == 0)
                {
                    System.Console.WriteLine("F");
                }
                else if (i % y == 0)
                {
                    System.Console.WriteLine("B");
                }
                else
                {
                    System.Console.WriteLine(i);
                }
            }



        }
    }
}
