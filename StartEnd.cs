using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivingChernobyl
{
    class StartEnd

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Can you survive in this facility?");
            //fix the intro, streamline this
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear();
            Intro();



            
            


        }

    
        public static void Intro()  //leads to breakroom and controlRoom | from Main
        {
            Console.WriteLine("Its 25 April, you just got done cleaning the break room");
            Console.WriteLine("Its 1245 AM and its time for your first break, what do you want to do");
            Console.WriteLine("\n1. Stay in the break room");
            Console.WriteLine("2. Talk to your friend in the control room");
            string choice = Console.ReadLine().ToLower().ToString();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "break room":
                case "go to break room":
                    {
                        TheBreakRoom.BreakRoom();
                        break;
                    }

                case "2":
                case "control room":
                case "go to control room":
                    {
                        TheControlRoom.ControlRoom();
                        break;
                    }


            }


        }


        public static void Win()
        {
            Docimeter winreading = new Docimeter();
            
            Console.WriteLine("You're tired");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You hear your name in the middle of the chaos, you look up and it is Dimitry");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("He tells you 'Do not go back inside'");
            Console.WriteLine("\n 'It doesn't matter who tells you, do not go back'");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("'leave as soon as you can, in fact if you can leave the country and never go back'");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("As you drive away from the facility, you hear a faint noise...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Your docimeter has been beeping the whole time and it reads\n");
            winreading.WinDose(winreading);
            Console.ReadLine();
            Console.Clear();
            Option();

        }   


     
        public static void GameOver() //stream line this too, pretty awkward (maybe say they die or shorten it)
        {
            Console.WriteLine("After a while, you start to feel sick");
            Console.ReadLine();
            Console.Clear();            
            Console.WriteLine("They eventually evacuate you to the closest hospital");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You wake up and in a hospital bed feeling groggy.  You overhear someone say...");
            Console.WriteLine("'None of them will make it\n none of them are going to survive'");
            Console.WriteLine("\n press any key to continue");
            Console.ReadLine();
            Console.Clear();
            Option();
            


        }
        public static void Option()
        {
            Console.WriteLine("Thanks for Playing");
            Console.WriteLine("To play again: Press '1' then enter");
            Console.WriteLine("To exit: Press 2 and exit the game");
            string choice = Console.ReadLine().ToLower().ToString();
            Console.Clear();

            switch (choice)
            {
                case "1":                
                    {
                        Intro();
                        break;
                    }

                case "2":
                case "exit":
                    {
                        
                        break;
                    }


            }

        }



    }

}

