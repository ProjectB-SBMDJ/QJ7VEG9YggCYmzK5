﻿using System;

using projectb;

namespace testproject1
{

    public class Menu
    {
        static bool chosen = true;
        public static void menu()
        {
            // day today
            var date = DateTime.Now;
            string a = date.ToString("dddd");
            Console.WriteLine("-------------------------------\n|     Welcome to the menu     |\n-------------------------------");
            Console.WriteLine(" [DO] - Daily offers \n [S] - Special offers\n [F] - Food\n [D] - Drink\n [am] - Add Menu");

            while (chosen)
            {
                Console.Write("Choose an option: ");
                string choiceM = Console.ReadLine();
                if (choiceM.Equals("do", StringComparison.OrdinalIgnoreCase))
                {
                    chosen = false;
                    Console.WriteLine("*** Welcome to the Daily Offers ***");
                    Console.WriteLine("     " + date.ToLongDateString());
                    csvcalls.DAILYOFFERS(); //get to the csv file DAILYOFFERS

                }
                else if (choiceM.Equals("s", StringComparison.OrdinalIgnoreCase))
                {
                    chosen = false;
                    Console.WriteLine("*** Welcome to the Special Offers ***************");
                    csvcalls.SPECIALS(); //get to the csv file specials

                }
                else if (choiceM.Equals("f", StringComparison.OrdinalIgnoreCase))
                {
                    chosen = false;
                    Console.WriteLine("*** Welcome to the Food Menu ***");
                    csvcalls.FOOD(); //get to the csv file food
                }
                else if (choiceM.Equals("d", StringComparison.OrdinalIgnoreCase))
                {
                    chosen = false;
                    Console.WriteLine("*** Welcome to the Drinks ***");
                    csvcalls.DRINKS(); //get to the csv file drinks
                }

                else if (choiceM.Equals("am", StringComparison.OrdinalIgnoreCase))
                {
                    chosen = false;
                    csvcalls.addMenu();
                }
                else if (choiceM.Equals("111", StringComparison.OrdinalIgnoreCase))
                {
                    //Dit is nog hier, maar dit moet naar het admin dingetje verplaats worden zodra hij klaar is
                    chosen = false;
                    Console.WriteLine("*aanpassen*");
                    csvcalls.CHANGEask();
                }

                else if (string.IsNullOrEmpty(choiceM))
                {   //EMPTY INPUT
                    Console.WriteLine("Not a valid input, please try again.");
                }
                else
                {   //INVALID INPUT
                    Console.WriteLine("Not a valid input, please try again.");
                }
            }
            backgo();
        }

        public static void backgo()
        {
            chosen = true;

            Console.WriteLine("\nDo you want to go back to the main menu?[yes/no]");
            string goback = Console.ReadLine();

            if (goback.Equals("no", StringComparison.OrdinalIgnoreCase))
            {
                menu();
            }
            else if (goback.Equals("yes", StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("\nWhat do you want to do?");
                Console.WriteLine("(Enter \'help\' to view the options)");
            }
            else
            {
                Console.WriteLine("Not a valid input, please try again.");
                backgo();
            }
        }

    }
}