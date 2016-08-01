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

            WorldState state = new WorldState();
            WorldState state2 = new WorldState();

            while (true)
            {
                // read command:
                string command = Console.ReadLine();

                if (command == "walk")
                {
                    state.numberOfTimesWalked += 1;
                    Console.WriteLine("You walk.");
                    Console.WriteLine("You have walked " + state.numberOfTimesWalked + " times");
                    Console.WriteLine("You have walked " + state2.numberOfTimesWalked + " times in alternate reality state2");

                    if (state.IsWin())
                    {
                        Console.WriteLine("You win!");
                        break;
                    }
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
