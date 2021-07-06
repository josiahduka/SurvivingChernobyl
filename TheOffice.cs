using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivingChernobyl
{
    class TheOffice //player will read all documents object created from documents class
                    //loop finished 
    {


        public static void Office1() //from closet instruction
        {
            Docimeter r2 = new Docimeter();
            Console.WriteLine("You walk into the office and hear a beep");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You look at your device and see");
            r2.OfficeDose(r2);
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You decide to look at some files while in the office");
            Console.WriteLine("\n1. Orders");
            Console.WriteLine("2. Bios");
            string choice = Console.ReadLine().ToLower().ToString();
            Console.Clear();
            switch (choice)
            {
                case "1":
                case "orders":
                    {

                        Console.Clear();
                        ReadOrders1();
                        break;
                    }
                case "2":
                case "bios":
                    {

                        Console.Clear();
                        Bios1();
                        break;
                    }


            }



        }
        public static void ReadOrders1() // from bio2 
        {


            Orders RedTab = new Orders
                (15117845,
                "'Report back as soon as testing is done, remember Mikhail and others within the party will see this'",
                "19 April 1986"
                );
            Orders GreenTab = new Orders(
                12158977,
                "'Pass out these new upgraded docimeters to your crew.  Make sure they know how to use it'",
                "25 March 1986"
                );
            Orders YellowTab = new Orders(
                1456931,
                "'New docimeters will have two readings\n" +
                "CPM stand for counts per minute and reads instant radiation within a persons area\n" +
                "REM stands for Roentgen equivalent man and reads total radiation absorbed" +
                "\n DO NOT GO ABOVE 90 REM",
                "25 March 1986"
                );
            Console.WriteLine("You see a documents marked with red, green and yellow tab");
            Console.WriteLine("You decide to read through all the documents");

            int ReadOrders = 0;
            while (ReadOrders < 3)
            {
                Console.WriteLine("\nChoose a color:");
                Console.WriteLine("\n1. Red");
                Console.WriteLine("2. Green");
                Console.WriteLine("3. Yellow");
                string choice = Console.ReadLine().ToLower().ToString();
                Console.Clear();
                switch (choice)
                {
                    case "1":
                    case "red":
                        {

                            RedTab.DisplayInfo();
                            Console.ReadLine();
                            Console.Clear();
                            break;

                        }
                    case "2":
                    case "green":
                        {

                            GreenTab.DisplayInfo();
                            Console.ReadLine();
                            Console.Clear();
                            break;

                        }
                    case "3":
                    case "yellow":
                        {
                            YellowTab.DisplayInfo();
                            Console.ReadLine();
                            Console.Clear();
                            break;


                        }


                }
                ReadOrders++;
                continue;

            }
            Console.WriteLine("Now you know about the docimeter device");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear();
            Bios2();


        }
        public static void ReadOrders2() // from bio2 
        {


            Orders RedTab = new Orders
                (15117845,
                "'Report back as soon as testing is done, remember Mikhail and others within the party will see this'",
                "19 April 1986"
                );
            Orders GreenTab = new Orders(
                12158977,
                "'Pass out these new upgraded docimeters to your crew.  Make sure they know how to use it'",
                "25 March 1986"
                );
            Orders YellowTab = new Orders(
                1456931,
                "'New docimeters will have two readings\n" +
                "CPM stand for counts per minute and reads instant radiation within a persons area\n" +
                "REM stands for Roentgen equivalent man and reads total radiation absorbed" +
                "\n DO NOT GO ABOVE 90 REM",
                "25 March 1986"
                );
            Console.WriteLine("You see a documents marked with red, green and yellow tab");
            Console.WriteLine("You decide to read through all the documents");

            int ReadOrders = 0;
            while (ReadOrders < 3)
            {
                Console.WriteLine("\nChoose a color:");
                Console.WriteLine("\n1. Red");
                Console.WriteLine("2. Green");
                Console.WriteLine("3. Yellow");
                string choice = Console.ReadLine().ToLower().ToString();
                Console.Clear();
                switch (choice)
                {
                    case "1":
                    case "red":
                        {

                            RedTab.DisplayInfo();
                            Console.ReadLine();
                            Console.Clear();
                            break;

                        }
                    case "2":
                    case "green":
                        {

                            GreenTab.DisplayInfo();
                            Console.ReadLine();
                            Console.Clear();
                            break;

                        }
                    case "3":
                    case "yellow":
                        {
                            YellowTab.DisplayInfo();
                            Console.ReadLine();
                            Console.Clear();
                            break;


                        }


                }
                ReadOrders++;
                continue;

            }
            Console.WriteLine("Now you know about the docimeter device");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear();
            TheUtilityCloset.UtilityCloset2();


        }
        public static void Bios1()  // From office | directs to orders
        {

            WorkerBio bio1 = new WorkerBio("Anatoly Dyatlov",
                 "Chief Nuclear Physicist",
               "Graduate of Moscow Engineering and Physics Institute",
               "Hired on 9 April 1973");

            WorkerBio bio2 = new WorkerBio("Dimitry Asiminov",
                "Nuclear Scientist",
               "St. Petersburg Polytechnic University ",
               "Hired on 30 December 1982");

            WorkerBio bio3 = new WorkerBio("Ivan Davydenko",
                "Custodial Staff",
               "No formal higher education",
               "Hired on 25 January 1893");


            Console.WriteLine("You approach the table that has folders containing some of the plant's workers");
            Console.WriteLine("You decide to read through all the documents");

            int ReadBios = 0;
            while (ReadBios < 3)
            {
                Console.WriteLine("choose a bio:");
                Console.WriteLine("\n1. Anatoly");
                Console.WriteLine("2. Dimitry");
                Console.WriteLine("3. Your bio");
                string choice = Console.ReadLine().ToLower().ToString();
                Console.Clear();
                switch (choice)
                {
                    case "1":
                    case "anatoly":
                        {

                            bio1.DisplayInfo();
                            Console.ReadLine();
                            Console.Clear();
                            break;

                        }
                    case "2":
                    case "Dimitry":
                        {

                            bio2.DisplayInfo();
                            Console.ReadLine();
                            Console.Clear();
                            break;

                        }
                    case "3":
                    case "your bio":
                        {
                            bio3.DisplayInfo();
                            Console.ReadLine();
                            Console.Clear();
                            break;


                        }


                }
                ReadBios++;
                continue;

            }
            Console.WriteLine("The alarms break your thoughts but you decide to read more documents\n");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear();
            ReadOrders2();


        }
        public static void Bios2()  // From readorders | directs to dimitry instruction
        {

            WorkerBio bio1 = new WorkerBio("Anatoly Dyatlov",
                 "Chief Nuclear Physicist",
               "Graduate of Moscow Engineering and Physics Institute",
               "Hired on 9 April 1973");

            WorkerBio bio2 = new WorkerBio("Dimitry Asiminov",
                "Nuclear Scientist",
               "St. Petersburg Polytechnic University ",
               "Hired on 30 December 1982");

            WorkerBio bio3 = new WorkerBio("Ivan Davydenko",
                "Custodial Staff",
               "No formal higher education",
               "Hired on 25 January 1893");


            Console.WriteLine("You approach the table that has folders containing some of the plant's workers");
            Console.WriteLine("You decide to read through all the documents");

            int ReadBios = 0;
            while (ReadBios < 3)
            {
                Console.WriteLine("choose a bio:");
                Console.WriteLine("\n1. Anatoly");
                Console.WriteLine("2. Dimitry");
                Console.WriteLine("3. Your bio");
                string choice = Console.ReadLine().ToLower().ToString();
                Console.Clear();
                switch (choice)
                {
                    case "1":
                    case "anatoly":
                        {

                            bio1.DisplayInfo();
                            Console.ReadLine();
                            Console.Clear();
                            break;

                        }
                    case "2":
                    case "Dimitry":
                        {

                            bio2.DisplayInfo();
                            Console.ReadLine();
                            Console.Clear();
                            break;

                        }
                    case "3":
                    case "your bio":
                        {
                            bio3.DisplayInfo();
                            Console.ReadLine();
                            Console.Clear();
                            break;


                        }


                }
                ReadBios++;
                continue;

            }            
            Console.WriteLine("The alarms break your thoughts and you remember you need a few items\n");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear();
            TheUtilityCloset.UtilityCloset2();


        }
        public static void Office2() //from Dimitry instruction
        {
            Docimeter r2 = new Docimeter();
            Console.WriteLine("You walk into the office and hear a beep");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You look at your device and see");
            r2.OfficeDose(r2);
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You decide to look at some files while in the office");
            Console.WriteLine("\n1. Orders");
            Console.WriteLine("2. Bios");
            string choice = Console.ReadLine().ToLower().ToString();
            Console.Clear();
            switch (choice)
            {
                case "1":
                case "orders":
                    {

                        Console.Clear();
                        ReadOrders3();
                        break;
                    }
                case "2":
                case "bios":
                    {

                        Console.Clear();
                        Bios3();
                        break;
                    }


            }
            



        }
        public static void ReadOrders3() // from office 
        {


            Orders RedTab = new Orders
                (15117845,
                "'Report back as soon as testing is done, remember Mikhail and others within the party will see this'",
                "19 April 1986"
                );
            Orders GreenTab = new Orders(
                12158977,
                "'Pass out these new upgraded docimeters to your crew.  Make sure they know how to use it'",
                "25 March 1986"
                );
            Orders YellowTab = new Orders(
                1456931,
                "New docimeters will have two readings\n" +
                "CPM stand for counts per minute and reads instant radiation within a persons area\n" +
                "REM stands for Roentgen equivalent man and reads total radiation absorbed" +
                "\n DO NOT GO ABOVE 90 REM",
                "25 March 1986"
                );
            Console.WriteLine("You see documents marked with red, green and yellow tab");
            Console.WriteLine("You decide to read through all the documents");

            int ReadOrders = 0;
            while (ReadOrders < 3)
            {

                Console.WriteLine("\nchoose a color:");
                Console.WriteLine("\n1. Red");
                Console.WriteLine("2. Green");
                Console.WriteLine("3. Yellow");
                string choice = Console.ReadLine().ToLower().ToString();
                Console.Clear();
                switch (choice)
                {
                    case "1":
                    case "red":
                        {

                            RedTab.DisplayInfo();
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                    case "2":
                    case "green":
                        {

                            GreenTab.DisplayInfo();
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                    case "3":
                    case "yellow":
                        {
                            YellowTab.DisplayInfo();
                            Console.ReadLine();
                            Console.Clear();
                            break;

                        }


                }
                ReadOrders++;
                continue;

            }
            Console.WriteLine("Now you know about the docimeter device");
            Console.WriteLine("But you are curious about the other documents on the table ");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear();
            Bios4();





        }
        public static void ReadOrders4() // from bio2 
        {


            Orders RedTab = new Orders
                (15117845,
                "'Report back as soon as testing is done, remember Mikhail and others within the party will see this'",
                "19 April 1986"
                );
            Orders GreenTab = new Orders(
                12158977,
                "'Pass out these new upgraded docimeters to your crew.  Make sure they know how to use it'",
                "25 March 1986"
                );
            Orders YellowTab = new Orders(
                1456931,
                "'New docimeters will have two readings\n" +
                "CPM stand for counts per minute and reads instant radiation within a persons area\n" +
                "REM stands for Roentgen equivalent man and reads total radiation absorbed" +
                "\n DO NOT GO ABOVE 90 REM",
                "25 March 1986"
                );
            Console.WriteLine("You see a documents marked with red, green and yellow tab");
            Console.WriteLine("You decide to read through all the documents");

            int ReadOrders = 0;
            while (ReadOrders < 3)
            {
                Console.WriteLine("\nchoose a color:");
                Console.WriteLine("\n1. Red");
                Console.WriteLine("2. Green");
                Console.WriteLine("3. Yellow");
                string choice = Console.ReadLine().ToLower().ToString();
                Console.Clear();
                switch (choice)
                {
                    case "1":
                    case "red":
                        {

                            RedTab.DisplayInfo();
                            Console.ReadLine();
                            Console.Clear();
                            break;

                        }
                    case "2":
                    case "green":
                        {

                            GreenTab.DisplayInfo();
                            Console.ReadLine();
                            Console.Clear();
                            break;

                        }
                    case "3":
                    case "yellow":
                        {
                            YellowTab.DisplayInfo();
                            Console.ReadLine();
                            Console.Clear();
                            break;


                        }


                }
                ReadOrders++;
                continue;

            }
            Console.WriteLine("you decide to head back to the control room");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            TheControlRoom.AfterClosetandOfficeDimitry();


        }                
        public static void Bios3() // from office
        {

            WorkerBio bio1 = new WorkerBio("Anatoly Dyatlov",
                "Chief Nuclear Physicist",
              "Graduate of Moscow Engineering and Physics Institute",
              "Hired on 9 April 1973");

            WorkerBio bio2 = new WorkerBio("Dimitry Asiminov",
                "Nuclear Scientist",
               "St. Petersburg Polytechnic University ",
               "Hired on 30 December 1982");

            WorkerBio bio3 = new WorkerBio("Ivan Davydenko",
                "Custodial Staff",               
               "No formal higher education",
               "Hired on 25 January 1893");

            Console.WriteLine("You approach the table that has folders containing some of the plant's workers");
            Console.WriteLine("You decide to read through all the documents");

            int ReadBios = 0;
            while (ReadBios < 3)
            {
                Console.WriteLine("choose a bio:");
                Console.WriteLine("\n1. Anatoly");
                Console.WriteLine("2. Dimitry");
                Console.WriteLine("3. Your bio");
                string choice = Console.ReadLine().ToLower().ToString();
                Console.Clear();
                switch (choice)
                {
                    case "1":
                    case "anatoly":
                        {

                            bio1.DisplayInfo();
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                    case "2":
                    case "Dimitry":
                        {

                            bio2.DisplayInfo();
                            Console.ReadLine();
                            Console.Clear();
                            break;

                        }
                    case "3":
                    case "your bio":
                        {
                            bio3.DisplayInfo();
                            Console.ReadLine();
                            Console.Clear();
                            break;


                        }


                }
                ReadBios++;
                continue;

            }

            Console.WriteLine("The alarms break your thoughts and you decide to read more documents\n");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear();
            ReadOrders4();

        }
        public static void Bios4() // from office
        {

            WorkerBio bio1 = new WorkerBio("Anatoly Dyatlov",
                 "Chief Nuclear Physicist",
               "Graduate of Moscow Engineering and Physics Institute",
               "Hired on 9 April 1973");

            WorkerBio bio2 = new WorkerBio("Dimitry Asiminov",
                "Nuclear Scientist",
               "St. Petersburg Polytechnic University ",
               "Hired on 30 December 1982");

            WorkerBio bio3 = new WorkerBio("Ivan Davydenko",
                "Custodial Staff",
               "No formal higher education",
               "Hired on 25 January 1893");

            Console.WriteLine("You approach the table that has folders containing some of the plant's workers");
            Console.WriteLine("You decide to read through all the documents");

            int ReadBios = 0;
            while (ReadBios < 3)
            {
                Console.WriteLine("choose a bio:");
                Console.WriteLine("\n1. Anatoly");
                Console.WriteLine("2. Dimitry");
                Console.WriteLine("3. Your bio");
                string choice = Console.ReadLine().ToLower().ToString();
                Console.Clear();
                switch (choice)
                {
                    case "1":
                    case "anatoly":
                        {

                            bio1.DisplayInfo();
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                    case "2":
                    case "Dimitry":
                        {

                            bio2.DisplayInfo();
                            Console.ReadLine();
                            Console.Clear();
                            break;

                        }
                    case "3":
                    case "your bio":
                        {
                            bio3.DisplayInfo();
                            Console.ReadLine();
                            Console.Clear();
                            break;


                        }


                }
                ReadBios++;
                continue;

            }

            Console.WriteLine("The alarms break your thoughts and you head back to see Dimitry\n");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear(); 
            TheControlRoom.AfterClosetandOfficeDimitry();

        }
    }
}
