using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsinC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // switch
            int age = 20;
            switch (age)
            {
                case 18:
                    Console.WriteLine("Please wait for an year");
                    break;
                case 20:
                    Console.WriteLine("you are 20");
                    break;
                default:
                    Console.WriteLine("Enjoy!");
                    break;

            }
            // Loops in C sharp
            // while loops
            int i = 0;
            while (i < 5) 
            {
                Console.WriteLine(i);
                i++;
            }
            // Do while loop
            int y = 0;
            do
            {
                Console.WriteLine(y + 1);
                y++;
            } while (y < 5);

            // For loop
            for (int z = 0; z < 5; z++)
            {
                if (z == 0)
                {
                    continue;
                }
                
                Console.WriteLine(z+1);
               // break;
            }
            Console.ReadLine();



        }
    }
}
