using System;

namespace testproject1
{
    public class Menu

    {

        public static void menu()

        {
            string menuSelection;
            bool menuRunning = true;

            void readMenuInput()
            {
                menuSelection = Console.ReadLine();
            }

            // day today
            var date = DateTime.Now;
            string a = date.ToString("dddd");

            void Menu()
            {
                Console.WriteLine("-------------------------------\n|     Welcome to the menu     |\n-------------------------------");
                Console.WriteLine(" [A] - Daily offers \n [B] - Special offers\n [C] - Food\n [D] - Drink\n [E] - Exit and back to the main page");
                Console.Write("Choose an option: ");
            }

            void DailyOffer() //Daily offers
            {

                Console.WriteLine("*** Welcome to the Daily Offers ***");

                // date today
                Console.WriteLine("     " + date.ToLongDateString());

                if (a.Equals("Monday", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\n*** The daily offer of today is  ***\n");
                    Console.WriteLine("[38] Pizza Salame + Salade for only €12 ");
                }
                else if (a.Equals("Tuesday", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\n*** The daily offer of today is  ***\n");
                    Console.WriteLine("[39] Filetto al Griglia + Smirnoff Vodka for only €35 ");
                }
                else if (a.Equals("Wednesday", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\n*** The daily offer of today is  ***\n");
                    Console.WriteLine("[40] Filetto al Funghi + Jack Daniel Whiskey for only €30 ");
                }
                else if (a.Equals("Thursday", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\n*** The daily offer of today is  ***\n");
                    Console.WriteLine("[41] Filetto al Pepe + Salade feta for only €15 ");
                }
                else if (a.Equals("Friday", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\n*** The daily offer of today is  ***\n");
                    Console.WriteLine("[42] Scaloppina romana + Moet & Chardon for only €50 ");
                }
                else if (a.Equals("Saturday", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\n*** The daily offer of today is  ***\n");
                    Console.WriteLine("[43] Pasta Carbonara + Heineken for only €10 ");

                }
                else if (a.Equals("Sunday", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\n*** The daily offer of today is  ***\n");
                    Console.WriteLine("[44] 2 Pizza Pollo + 2 Soft Drinks for only €20 ");
                }

            }

            void SpecialOffer() //Special offers
            {
                Console.WriteLine("*** Welcome to the Special Offers ***************");
                Console.WriteLine("[32]------------Pizza + Soft Drink------------€10");
                Console.WriteLine("[33]------------Pasta + Soft Drink------------€9");
                Console.WriteLine("[34]------------Pizza + Salade----------------€12");
                Console.WriteLine("[35]------------Pasta + Salade----------------€10");
                Console.WriteLine("[36]------------Meat + Salade-----------------€13");
                Console.WriteLine("[37]------------Meat + Soft Drink-------------€11");
                Console.WriteLine("*************************************************");

            }

            void Food() // Food
            {
                Console.WriteLine("*** Welcome to the Food ***");
                Console.WriteLine("*****************PIZZA**************************");
                Console.WriteLine("[14]------------Pizza funghi------------------€9");
                Console.WriteLine("[15]------------Pizza Margherita--------------€8");
                Console.WriteLine("[16]------------Pizza Salame------------------€9");
                Console.WriteLine("[17]------------Pizza Pollo-------------------€9");
                Console.WriteLine("[18]------------Pizza Tonno-------------------€9");
                Console.WriteLine("*****************PASTA**************************");
                Console.WriteLine("[19]------------Pasta Carbonara---------------€8");
                Console.WriteLine("[20]------------Pasta Bolognese---------------€8");
                Console.WriteLine("[21]------------Pasta Siciliana---------------€9");
                Console.WriteLine("[22]------------Pasta Pollo e funghi----------€7");
                Console.WriteLine("*****************MEAT***************************");
                Console.WriteLine("[23]------------Filetto al Pepe---------------€10");
                Console.WriteLine("[24]------------Filetto al Griglia------------€12");
                Console.WriteLine("[25]------------Filetto al Funghi-------------€13");
                Console.WriteLine("[26]------------Scaloppina Romana-------------€15");
                Console.WriteLine("*****************SALADE*************************");
                Console.WriteLine("[27]------------Salade Mista------------------€6");
                Console.WriteLine("[28]------------Salade Rucola-----------------€5");
                Console.WriteLine("[29]------------Salade Mozzarella-------------€7");
                Console.WriteLine("[30]------------Salade Tonno------------------€8");
                Console.WriteLine("[31]------------Salade feta-------------------€7");
                Console.WriteLine("************************************************");
            }

            void Drink() //Drink
            {
                Console.WriteLine("*** Welcome to the Drinks ***");
                Console.WriteLine("*****************BEERS**************************");
                Console.WriteLine("[1]------------Heineken-----------------------€4");
                Console.WriteLine("[2]------------Amstel-------------------------€4");
                Console.WriteLine("[3]------------Blue Moon----------------------€4");
                Console.WriteLine("*****************SOFT DRINKS********************");
                Console.WriteLine("[4]------------Lemonade-----------------------€3");
                Console.WriteLine("[5]------------Coke---------------------------€3");
                Console.WriteLine("[6]------------Tonic Water--------------------€2");
                Console.WriteLine("[7]------------Soda Water---------------------€2");
                Console.WriteLine("*****************SPIRITS************************");
                Console.WriteLine("[8]------------Jack Daniel Whiskey------------€20");
                Console.WriteLine("[9]------------Smirnoff Vodka-----------------€30");
                Console.WriteLine("[10]------------Gordon's Gin------------------€25");
                Console.WriteLine("*****************CHAMPAGNE**********************");
                Console.WriteLine("[11]------------Moet & Chardon----------------€40");
                Console.WriteLine("[12]------------Bollinger---------------------€35");
                Console.WriteLine("[13]------------Jeio Prosecco-----------------€35");
                Console.WriteLine("************************************************");
            }



            Console.WriteLine("\n----Welcome to the Menu Page----");
            Console.WriteLine("Enter \'help\' to see the options");
            while (menuRunning)
            {
                readMenuInput();

                switch (menuSelection.ToLower())
                {
                    case "a":
                        DailyOffer();
                        Console.WriteLine("\nWhat would you like to do now? (enter \'help\' to see options)");
                        break;
                    case "b":
                        SpecialOffer();
                        Console.WriteLine("\nWhat would you like to do now? (enter \'help\' to see options)");
                        break;
                    case "c":
                        Food();
                        Console.WriteLine("\nWhat would you like to do now? (enter \'help\' to see options)");
                        break;
                    case "d":
                        Drink();
                        Console.WriteLine("\nWhat would you like to do now? (enter \'help\' to see options)");
                        break;
                    case "help":
                        Menu();
                        break;
                    case "e":
                        Console.WriteLine("\n----Welcome Back To The Main Menu----");
                        Console.WriteLine("Enter \'help\' to view the options!");
                        menuRunning = false;
                        break;
                    case "":        //empty input
                    case null:      // is invalid
                        Console.WriteLine("Empty input, please try again.");
                        break;
                    default:
                        Console.WriteLine("Not a valid input, please try again.");
                        break;

                }
            }
        }
    }

}