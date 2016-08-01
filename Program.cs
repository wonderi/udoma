using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udoma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Udoma!!!");

            while (true)
            {
                // read command:
                string command = Console.ReadLine();

                if (command == "walk")
                {
                    Console.WriteLine("Walkety walk walk. You happy now!??");
                    Console.WriteLine("Ha!");
                }
                else
                {
                    Console.WriteLine("You Lose!");
                    break;
                }

                // show results to player
            }


            Console.ReadLine();
        }
    }
}
