using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivingChernobyl
{
    class TheAlarms
    {

        public static void Alarms()  //leads to hallway, controlroom2  | from readingbook and breakroom 
        {
            Console.WriteLine("All warning lights come on, and your coworkers start heading out of the room\n");
            Console.WriteLine("\nYou decide to: ");
            Console.WriteLine("1. Follow your coworkers");
            Console.WriteLine("2. Go to the Lab");
            string choice = Console.ReadLine().ToLower().ToString();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "follow coworkers":
                    {
                        TheHall.Hallway();
                        break;
                    }
                case "2":
                case "Go to the lab":
                    {

                        TheControlRoom.ControlRoom2();
                        break;
                    }


            }


        }
        public static void Alarm2() //to dimitryinstruction, anatoly instruction | from control room 2
        {
            Docimeter dc = new Docimeter();;
            Console.WriteLine("While the whole room panics because of all the alarms and you pick up a device that was knocked to the ground...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You look at the small monitor on the device and it reads");
            Console.WriteLine($"CPM: {dc.CPM}\nREM: {dc.REM}");
            Console.WriteLine("What do you do want to do");
            Console.WriteLine("\n1. Talk to Dimitry");
            Console.WriteLine("2. Talk to Anatoly");
            string choice = Console.ReadLine().ToLower().ToString();
            Console.Clear();
            switch (choice)
            {
                case "1":
                case "talk to dimitry":
                case "dimitry":
                    {

                        Console.Clear();
                        TheControlRoom.DimitryInstruction();
                        break;
                    }
                case "2":
                case "talk to anatoly":
                case "anatoly":
                    {

                        Console.WriteLine("You see Anatoly light a cigarette and stare blankly at the wall");
                        Console.WriteLine("YOu can't find Dimitry anywhere so you head to the hallway");
                        Console.ReadLine();
                        TheHall.Hallway();
                        break;
                    }



            }

        }

    }

}
