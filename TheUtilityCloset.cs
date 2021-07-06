using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivingChernobyl
{
    public enum Drawers
    {
        Gloves = 1,
        Bands = 2,
        Tarp = 3,
        Mask = 4,
    }
    class TheUtilityCloset
    {
        public static void UtilityCloset()
        {



            var d1 = (Drawers)1;
            var d2 = (Drawers)2;
            var d3 = (Drawers)3;
            var d4 = (Drawers)4;

            Console.WriteLine($"You arrive at the closet where you think you might find {d1} and {d4}");
            Console.WriteLine("You see 4 large drawers, you must choose two");
            Console.WriteLine("Choose the first drawer");
            Console.WriteLine("\n1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.Write("4\nDrawer #: ");
            int choice1 = Convert.ToInt32(Console.ReadLine().ToLower());
            Console.Clear();



            while (choice1 != 1 || choice1 != 4)
            {

                if (choice1 == 1)
                {
                    Console.WriteLine($"Congrats! found the first item {d1} ");
                    Console.WriteLine("Choose another drawer");
                    Console.WriteLine("\n2");
                    Console.WriteLine("3");
                    Console.Write("4\nDrawer #: ");
                    int choice_1a = Convert.ToInt32(Console.ReadLine().ToLower());
                    Console.Clear();

                    while (choice_1a != 4)
                    {

                        if (choice_1a == 4)
                        {
                            Console.WriteLine($"Congrats! found the secind item: {d4}");
                            Console.ReadLine();

                            break;

                        }
                        else if (choice_1a == 2)
                        {
                            Console.WriteLine($"You found {d2}\nchoose again");
                            Console.WriteLine("\n2");
                            Console.WriteLine("3");
                            Console.Write("4\nDrawer #: ");
                            choice_1a = Convert.ToInt32(Console.ReadLine().ToLower());
                            Console.Clear();
                            continue;
                        }
                        else if (choice_1a == 3)
                        {
                            Console.WriteLine($"You found {d3}\nchoose again");
                            Console.WriteLine("\n2");
                            Console.WriteLine("3");
                            Console.Write("4\nDrawer #: ");
                            choice_1a = Convert.ToInt32(Console.ReadLine().ToLower());
                            Console.Clear();
                            continue;
                        }





                    }
                    Console.WriteLine($"Congrats! found the second item: {d4}");
                    Console.ReadLine();
                    Console.Clear();
                    break;




                }
                else if (choice1 == 2)
                {
                    Console.WriteLine($"You found {d2}\nchoose again");
                    Console.WriteLine("\n1");
                    Console.WriteLine("2");
                    Console.WriteLine("3");
                    Console.Write("4\nDrawer #: ");
                    choice1 = Convert.ToInt32(Console.ReadLine().ToLower());
                    Console.Clear();
                    continue;
                }
                else if (choice1 == 3)
                {
                    Console.WriteLine($"You found {d3}\nchoose again");
                    Console.WriteLine("\n1");
                    Console.WriteLine("2");
                    Console.WriteLine("3");
                    Console.Write("4\nDrawer #: ");
                    choice1 = Convert.ToInt32(Console.ReadLine().ToLower());
                    Console.Clear();
                    continue;
                }
                else if (choice1 == 4)
                {
                    Console.WriteLine($"Congrats! found the first item {d4} ");
                    Console.WriteLine("Choose another drawer");
                    Console.WriteLine("\n1");
                    Console.WriteLine("2");
                    Console.WriteLine("3\nDrawer #: ");
                    int choice_4a = Convert.ToInt32(Console.ReadLine().ToLower());
                    Console.Clear();

                    while (choice_4a != 1)
                    {

                        if (choice_4a == 1)
                        {
                            Console.WriteLine($"Congrats! found the secind item: {d1}");
                            Console.ReadLine();

                            break;

                        }
                        else if (choice_4a == 2)
                        {
                            Console.WriteLine($"You found {d2}\nchoose again");
                            Console.WriteLine("1");
                            Console.WriteLine("2");
                            Console.WriteLine("3\nDrawer #: ");
                            choice_4a = Convert.ToInt32(Console.ReadLine().ToLower());
                            Console.Clear();
                            continue;
                        }
                        else if (choice_4a == 3)
                        {
                            Console.WriteLine($"You found {d3}\nchoose again");
                            Console.WriteLine("1");
                            Console.WriteLine("2");
                            Console.WriteLine("3\nDrawer #: ");
                            choice_4a = Convert.ToInt32(Console.ReadLine().ToLower());
                            Console.Clear();
                            continue;
                        }





                    }
                    Console.WriteLine($"Congrats! found the second item: {d1}");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                }
                continue;

            }





            Console.WriteLine($"You found {d1} and {d4}");
            Console.WriteLine("As you walk back to the control room, you see the office doors open and decide to go in");
            Console.ReadLine();
            Console.Clear();
            TheOffice.Office2();








        }

        public static void UtilityCloset2()
        {



            var d1 = (Drawers)1;
            var d2 = (Drawers)2;
            var d3 = (Drawers)3;
            var d4 = (Drawers)4;

            Console.WriteLine($"You arrive at the closet where you think you might find {d1} and {d4}");
            Console.WriteLine("You see 4 large drawers, you must choose two");
            Console.WriteLine("Choose the first drawer");
            Console.WriteLine("\n1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.Write("4\nDrawer #: ");
            int choice1 = Convert.ToInt32(Console.ReadLine().ToLower());
            Console.Clear();



            while (choice1 != 1 || choice1 != 4)
            {

                if (choice1 == 1)
                {
                    Console.WriteLine($"Congrats! found the first item {d1} ");
                    Console.WriteLine("Choose another drawer");
                    Console.WriteLine("\n2");
                    Console.WriteLine("3");
                    Console.Write("4\nDrawer #: ");
                    int choice_1a = Convert.ToInt32(Console.ReadLine().ToLower());
                    Console.Clear();

                    while (choice_1a != 4)
                    {

                        if (choice_1a == 4)
                        {
                            Console.WriteLine($"Congrats! found the secind item: {d4}");
                            Console.ReadLine();

                            break;

                        }
                        else if (choice_1a == 2)
                        {
                            Console.WriteLine($"You found {d2}\nchoose again");
                            Console.WriteLine("\n2");
                            Console.WriteLine("3");
                            Console.Write("4\nDrawer #: ");
                            choice_1a = Convert.ToInt32(Console.ReadLine().ToLower());
                            Console.Clear();
                            continue;
                        }
                        else if (choice_1a == 3)
                        {
                            Console.WriteLine($"You found {d3}\nchoose again");
                            Console.WriteLine("\n2");
                            Console.WriteLine("3");
                            Console.Write("4\nDrawer #: ");
                            choice_1a = Convert.ToInt32(Console.ReadLine().ToLower());
                            Console.Clear();
                            continue;
                        }





                    }
                    Console.WriteLine($"Congrats! found the second item: {d4}");
                    Console.ReadLine();
                    Console.Clear();
                    break;




                }
                else if (choice1 == 2)
                {
                    Console.WriteLine($"You found {d2}\nchoose again");
                    Console.WriteLine("\n1");
                    Console.WriteLine("2");
                    Console.WriteLine("3");
                    Console.Write("4\nDrawer #: ");
                    choice1 = Convert.ToInt32(Console.ReadLine().ToLower());
                    Console.Clear();
                    continue;
                }
                else if (choice1 == 3)
                {
                    Console.WriteLine($"You found {d3}\nchoose again");
                    Console.WriteLine("\n1");
                    Console.WriteLine("2");
                    Console.WriteLine("3");
                    Console.Write("4\nDrawer #: ");
                    choice1 = Convert.ToInt32(Console.ReadLine().ToLower());
                    Console.Clear();
                    continue;
                }
                else if (choice1 == 4)
                {
                    Console.WriteLine($"Congrats! found the first item {d4} ");
                    Console.WriteLine("Choose another drawer");
                    Console.WriteLine("\n1");
                    Console.WriteLine("2");
                    Console.WriteLine("3\nDrawer #: ");
                    int choice_4a = Convert.ToInt32(Console.ReadLine().ToLower());
                    Console.Clear();

                    while (choice_4a != 1)
                    {

                        if (choice_4a == 1)
                        {
                            Console.WriteLine($"Congrats! found the secind item: {d1}");
                            Console.ReadLine();

                            break;

                        }
                        else if (choice_4a == 2)
                        {
                            Console.WriteLine($"You found {d2}\nchoose again");
                            Console.WriteLine("\n1");
                            Console.WriteLine("2");
                            Console.WriteLine("3\nDrawer #: ");
                            choice_4a = Convert.ToInt32(Console.ReadLine().ToLower());
                            Console.Clear();
                            continue;
                        }
                        else if (choice_4a == 3)
                        {
                            Console.WriteLine($"You found {d3}\nchoose again");
                            Console.WriteLine("\n1");
                            Console.WriteLine("2");
                            Console.WriteLine("3\nDrawer #: ");
                            choice_4a = Convert.ToInt32(Console.ReadLine().ToLower());
                            Console.Clear();
                            continue;
                        }





                    }
                    Console.WriteLine($"Congrats! found the second item: {d1}");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                }
                continue;

            }





            Console.WriteLine($"You found {d1} and {d4}");
            Console.WriteLine("You need to return to Dimitry");
            Console.ReadLine();
            Console.Clear();
            TheControlRoom.AfterClosetandOfficeDimitry();








        }



    }


    
}
