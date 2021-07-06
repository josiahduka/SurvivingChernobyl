using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivingChernobyl
{
    class TheBreakRoom
    {
        public static void BreakRoom() ///leads to alarms and reading book | from firstevent 
        {
            Console.WriteLine("Its time for your break");
            Console.WriteLine("What do you want to do for your break");
            Console.WriteLine("\n1. Take a nap");
            Console.WriteLine("2. Read your book");
            string choice1 = Console.ReadLine().ToLower().ToString();
            Console.Clear();

            switch (choice1)
            {
                case "1":
                case "nap":
                case "take a nap":

                    {
                        Console.WriteLine("you fall asleep sitting down, when suddenly...");
                        Console.ReadLine();
                        TheAlarms.Alarms();
                        break;
                    }
                case "2":
                case "read":
                case "read book":
                    {


                        ReadingBook();
                        break;
                    }


            }


        }

        public static void ReadingBook() //leads to alarms | from breakroom
        {

            Console.WriteLine("You pick up your book and turn to page...");
            Console.WriteLine("(you get to chooose the page!)");
            int pagenum = int.Parse(Console.ReadLine());
            Console.Clear();

            while (pagenum < 50)
            {
                Console.WriteLine("I'm so busy that I can't believe i'm only in page " + pagenum);
                Console.WriteLine("choose another page");
                pagenum = int.Parse(Console.ReadLine());
                Console.Clear();
                continue;
            }

            Console.WriteLine("you stop at page: " + pagenum);
            Console.WriteLine("when suddenly...");
            Console.ReadLine();
            Console.Clear();



            TheAlarms.Alarms();



        }
       
        


    }
}
