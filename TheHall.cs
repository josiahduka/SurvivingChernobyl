using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivingChernobyl
{
    class TheHall
    {
        public static void Hallway() //only leads to gameover | from alarms, controlroom, controlroom2
        {
            Console.WriteLine("As you walk down the smoke filled hallway");
            Console.WriteLine("You see someone who is coughing profusely");
            Console.WriteLine("You see an open door with smoke coming from inside. You look in there...");
            Console.ReadLine();
            Console.Clear();
            StartEnd.GameOver();

        }
        public static void Hallway2() //only leads to gameover | from alarms, controlroom, controlroom2
        {
            Console.WriteLine("You go from room to room helping people find their way out");
            Console.WriteLine("You notice the hallways are empty and feel the temperature rising");            
            Console.WriteLine("\n1. Go outside");
            Console.WriteLine("2. Find Dimitry");
            string choice = Console.ReadLine().ToLower().ToString();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "go outside":
                case "outside":
                    {
                        OutsideFacility.Outside();
                        break;
                    }
                case "2":
                case "find dimitry"://branch needs to be developed
                    {


                        TheControlRoom.FindDimitry();
                        break;
                    }

            }

        }
    }
}
