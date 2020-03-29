using System;

namespace testproject1
{
    class Menu

    {
        static bool ask;

        public static void menu()
        {

            {

                // day today yo maar nu kan j gwn vanuit de github folder werken
                var date = DateTime.Now;
                string a = date.ToString("dddd");


                Console.WriteLine("-------------------------------\n|     Welcome to the menu     |\n-------------------------------");

                {
                    Console.WriteLine(" [A] - Daily offers \n [B] - Special offers\n [C] - Food\n [D] - Drink");

                    Console.Write("Choose an option: ");
                    string choiceM = Console.ReadLine();

                    {




                        if (choiceM.Equals("A", StringComparison.OrdinalIgnoreCase))
                        {   //Daily offers


                            Console.WriteLine("*** Welcome to the Daily Offers ***");

                            // date today
                            Console.WriteLine("     " + date.ToLongDateString());

                            if (a.Equals("Monday", StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("\n*** The daily offer of today is  ***\n");
                            }
                            else if (a.Equals("Tuesday", StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("\n*** The daily offer of today is  ***\n");
                            }
                            else if (a.Equals("Wednesday", StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("\n*** The daily offer of today is  ***\n");
                            }
                            else if (a.Equals("Thursday", StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("\n*** The daily offer of today is  ***\n");
                            }
                            else if (a.Equals("Friday", StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("\n*** The daily offer of today is  ***\n");
                            }
                            else if (a.Equals("Saturday", StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("\n*** The daily offer of today is  ***\n");


                            }
                            else if (a.Equals("Sunday", StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("\n*** The daily offer of today is  ***\n");


                            }


                        }
                        else if (choiceM.Equals("B", StringComparison.OrdinalIgnoreCase))
                        {   //Special offers
                            Console.WriteLine("*** Welcome to the Special Offers ***");
                            Console.WriteLine("[32]------------Pizza + Drink-----------------");
                            Console.WriteLine("[33]------------Pasta + Drink-----------------");
                            Console.WriteLine("[34]------------Pizza + Salade----------------");
                            Console.WriteLine("[35]------------Pasta + Salade----------------");
                            Console.WriteLine("[36]------------Meat + Salade-----------------");
                            Console.WriteLine("[37]------------Meat + Drink------------------");
                            Console.WriteLine("**********************************************");


                        }
                        else if (choiceM.Equals("C", StringComparison.OrdinalIgnoreCase))
                        {   //Food
                            Console.WriteLine("*** Welcome to the Food ***");
                            Console.WriteLine("*****************PIZZA************************");
                            Console.WriteLine("[14]------------Pizza funghi------------------");
                            Console.WriteLine("[15]------------Pizza Margherita--------------");
                            Console.WriteLine("[16]------------Pizza Salame------------------");
                            Console.WriteLine("[17]------------Pizza Pollo-------------------");
                            Console.WriteLine("[18]------------Pizza Tonno-------------------");
                            Console.WriteLine("*****************PASTA************************");
                            Console.WriteLine("[19]------------Pasta Carbonara---------------");
                            Console.WriteLine("[20]------------Pasta Bolognese---------------");
                            Console.WriteLine("[21]------------Pasta Siciliana---------------");
                            Console.WriteLine("[22]------------Pasta Pollo e funghi----------");
                            Console.WriteLine("*****************MEAT*************************");
                            Console.WriteLine("[23]------------Filetto al Pepe---------------");
                            Console.WriteLine("[24]------------Filetto al Griglia------------");
                            Console.WriteLine("[25]------------Filetto al Funghi-------------");
                            Console.WriteLine("[26]------------Scaloppina romana-------------");
                            Console.WriteLine("*****************SALADE***********************");
                            Console.WriteLine("[27]------------Salade Mista------------------");
                            Console.WriteLine("[28]------------Salade Rucola-----------------");
                            Console.WriteLine("[29]------------Salade Mozzarella-------------");
                            Console.WriteLine("[30]------------Salade Tonno------------------");
                            Console.WriteLine("[31]------------Salade feta-------------------");
                            Console.WriteLine("**********************************************");



                        }
                        else if (choiceM.Equals("D", StringComparison.OrdinalIgnoreCase))
                        {   //Drink
                            Console.WriteLine("*** Welcome to the Drinks ***");
                            Console.WriteLine("*****************BEERS************************");
                            Console.WriteLine("[1]------------Heineken-----------------------");
                            Console.WriteLine("[2]------------Amstel-------------------------");
                            Console.WriteLine("[3]------------Blue Moon----------------------");
                            Console.WriteLine("*****************SOFT DRINKS******************");
                            Console.WriteLine("[4]------------Lemonade-----------------------");
                            Console.WriteLine("[5]------------Coke---------------------------");
                            Console.WriteLine("[6]------------Tonic Water--------------------");
                            Console.WriteLine("[7]------------Soda Water---------------------");
                            Console.WriteLine("*****************SPIRITS**********************");
                            Console.WriteLine("[8]------------Jack Daniel Whiskey------------");
                            Console.WriteLine("[9]------------Smirnoff Vodka-----------------");
                            Console.WriteLine("[10]------------Gordon's Gin------------------");
                            Console.WriteLine("*****************CHAMPAGNE********************");
                            Console.WriteLine("[11]------------Moet & Chardon----------------");
                            Console.WriteLine("[12]------------Bollinger---------------------");
                            Console.WriteLine("[13]------------Jeio Prosecco-----------------");
                            Console.WriteLine("**********************************************");



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
                }
            }
        }

    }
}