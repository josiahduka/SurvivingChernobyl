using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivingChernobyl
{
    class TheControlRoom
    {
        public static void ControlRoom() //leads to alarm2 and hallway | from firstevent, 
        {
            Console.WriteLine("You walk into the control room");
            Console.WriteLine("You see your friend Dimitry and another scientist standing beside him with a name tag that says 'Anatoly'");
            Console.WriteLine("\n1. Talk to Dimitry");
            Console.WriteLine("2. Talk to Anatoly");
            string choice = Console.ReadLine().ToLower().ToString();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "dimitry":
                    {
                        Console.WriteLine("we're pretty busy right now, but you can wait around if you want");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("As you wait for Dimitry to take his break, you feel the building suddenly shake and alarms go off");
                        Console.WriteLine("\nPress Enter to continue");
                        Console.ReadLine();
                        Console.Clear();
                        TheAlarms.Alarm2();
                        break;
                    }
                case "2":
                case "anatoly":
                    {

                        Console.WriteLine("'Can't you see were busy, come back later'");
                        Console.WriteLine("As you walk down the hallway you feel the building suddenly shake and the alarms go off");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        Console.Clear();
                        TheHall.Hallway();
                        break;
                    }
            }

        }
        public static void ControlRoom2() // to alarm2 and hallway | from alarms, 
        {
            Console.WriteLine("You walk into the control room and see your friend Dimitry\nstanding beside him you see man who's name tag says ''Anatoly'");
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
                        Console.WriteLine("Dimitry says: 'Now is not a good time'...");
                        Console.ReadLine();
                        Console.Clear();
                        TheAlarms.Alarm2();
                        break;
                    }
                case "2":
                case "talk to anatoly":
                    {

                        Console.WriteLine("You see Anatoly staring at the wall, muttering under his breath\n\nYou decide to head out to see if you can help others");
                        Console.ReadLine();
                        Console.Clear();
                        TheHall.Hallway();
                        break;
                    }



            }
        }
        public static void DimitryInstruction() // to utility closet and office | from alarm2
        {

            Console.WriteLine("Dimitry tells you: 'I don't have time to explain right now but you need to grab two things: a mask and some gloves'");
            Console.WriteLine("Where do you want to look for these items");
            Console.WriteLine("\n1. Utility Closet");
            Console.WriteLine("2. Offices");
            string choice = Console.ReadLine().ToLower().ToString();
            Console.Clear();
            switch (choice)
            {
                case "1":
                case "utility closet":
                case "closet":
                    {

                        Console.Clear();
                        TheUtilityCloset.UtilityCloset();  //needs utility closest
                        break;
                    }
                case "2":
                case "offices":
                    {

                        Console.Clear();
                        TheOffice.Office1();
                        break;
                    }


            }


        }
        public static void AfterClosetandOfficeDimitry()
        {
            Console.WriteLine("As you walk into the control room, Dimitry approaches you");
            Console.WriteLine("'Something horrible happened tonight, but no matter what happens\n do not take the mask or gloves off'");
            Console.WriteLine("'now, I need you to evacuate the facility");
            Console.WriteLine("\n1. Go help inside");
            Console.WriteLine("2. go help outside");
            string choice = Console.ReadLine().ToLower().ToString();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "go to the hallway":
                case "hallway":
                    {
                        TheHall.Hallway2();
                        break;
                    }
                case "2":
                case "outside":
                case "go outside":
                    {

                        OutsideFacility.Outside();
                        break;
                    }

            }





        }

        public static void FindDimitry()
        {
            Console.WriteLine("You walk back to the control room to look for Dimitry");
            Console.WriteLine("You hear someone say 'come here I need your help'\nYou see Anatoly waving at you");
            Console.WriteLine("'Dimitry and I need your help, come with me'");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("While you help Anatoly inside the darm room, you see Dimitry walking up");
            Console.WriteLine("He freezes and looks at you with fear in his eyes");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("The two scientists argued for a while,\nEventually you hear Dimitry sternly say");
            Console.WriteLine("leave now");
            Console.ReadLine();
            Console.Clear();
            TheHall.Hallway();









        }





    }

}
