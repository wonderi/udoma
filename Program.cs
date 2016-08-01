using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace udoma
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument adventureDoc = XDocument.Load("Data/adventure.xml");
            string introductionText = adventureDoc.Root.Element("Introduction").Value;
            string loseMessage = adventureDoc.Root.Element("LoseMessage").Value;

            Console.WriteLine(introductionText);

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
                    Console.WriteLine(loseMessage);
                    break;
                }

                // show results to player
            }


            Console.ReadLine();
        }
    }
}
