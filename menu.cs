using System;

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
            Console.WriteLine("-----------------------`    |\n-------------------------------");
            Console.WriteLine(" [DO] - Daily offers \n [S] - Special offers\n [F] - Food\n [D] - Drink");
          
            while (chosen)
            {
                Console.Write("Choose an option: ");
                string choiceM = Console.ReadLine();
                if (choiceM.Equals("do", StringComparison.OrdinalIgnoreCase))
                {
                    chosen = false;
                    DailyOffer();
                    void DailyOffer() //Daily offers
                    {
                        Console.WriteLine("*** Welcome to the Daily Offers ***");
                        // date today
                        Console.WriteLine("     " + date.ToLongDateString());
                    }
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

            Console.WriteLine("\nDo you want to go back?[yes/no]");
            string goback = Console.ReadLine();

            if (goback.Equals("yes", StringComparison.OrdinalIgnoreCase))
            {
                menu();
            }
            else if (goback.Equals("no", StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("\nWhat do you want to do?");
                Console.WriteLine("(Enter \'help\' to view the options)");
            }
            else
            {
                Console.WriteLine("Not a valid input, please try again.");
                backgo();
            }



            Console.WriteLine("\n----Welcome to the Menu Page----");
            Console.WriteLine("Enter \'help\' to see the options");
      //     while (menuRunning)
      //      {
      //          readMenuInput();
      //
      //          switch (menuSelection.ToLower())
      //         {
      //              case "a":
      //                  DailyOffer();
      //                  Console.WriteLine("\nWhat would you like to do now? (enter \'help\' to see options)");
      //                  break;
      //             case "b":
      //                 SpecialOffer();
      //                 Console.WriteLine("\nWhat would you like to do now? (enter \'help\' to see options)");
      //                  break;
      //              case "c":
      //                  Food();
      //                  Console.WriteLine("\nWhat would you like to do now? (enter \'help\' to see options)");
      //                  break;
      //              case "d":
      //                 Drink();
      //                 Console.WriteLine("\nWhat would you like to do now? (enter \'help\' to see options)");
      //                  break;
      //              case "help":
      //                  Menu();
      //                  break;
      //              case "e":
      //                  Console.WriteLine("\n----Welcome Back To The Main Menu----");
      //                  Console.WriteLine("Enter \'help\' to view the options!");
      //                  menuRunning = false;
      //                break;
      //              case "":        //empty input
      //              case null:      // is invalid
      //                  Console.WriteLine("Empty input, please try again.");
      //                  break;
      //              default:
      //                 Console.WriteLine("Not a valid input, please try again.");
      //                  break;
      //
      //          }
      //      }
        }
    }

}