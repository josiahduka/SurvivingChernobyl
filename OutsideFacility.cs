using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivingChernobyl
{
    class OutsideFacility
    {

        public static void Outside()
        {
            Console.WriteLine("Panic everywhere outside the facility");
            Console.WriteLine("Finally, you see some ambulances and firefighters");
            Console.WriteLine("What do you do");
            Console.WriteLine("\n1. help the first responders");
            Console.WriteLine("2. sit down");
            string choice = Console.ReadLine().ToLower().ToString();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "help the first responders":
                case "help":
                    {
                        HelpFirstResponders();
                        break;
                    }

                case "2":
                case "sit down":
                case "sit":
                    {
                        StartEnd.Win();
                        break;
                    }
            }


        }
        public static void HelpFirstResponders()
        {
            Console.WriteLine("You offer your help and the firefighters are grateful");
            Console.WriteLine("They take you to the area where the smoke is at its thickest");            
            Console.WriteLine("\nYou help the firefighters as much as you can");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You cant help but notice the smoke coming from the rubble...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You taste the metal in the air...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("And you feel the almost unbearable heat in the middle of the night...");
            Console.ReadLine();
            Console.Clear();
            StartEnd.GameOver();


        }
    }
}
