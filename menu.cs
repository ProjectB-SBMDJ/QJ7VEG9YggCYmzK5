using System;

using projectb;

namespace testproject1
{
    
    public class Menu
    {
        public static void menu()
        {
            // day today
            var date = DateTime.Now;
            string a = date.ToString("dddd");

            Menu();
            void Menu()
            {



                Console.WriteLine("-------------------------------\n|     Welcome to the menu     |\n-------------------------------");

                {
                    Console.WriteLine(" [A] - Daily offers \n [B] - Special offers\n [F] - Food\n [D] - Drink");

                    Console.Write("Choose an option: ");
                    string choiceM = Console.ReadLine();

                    {


                        if (choiceM.Equals("A", StringComparison.OrdinalIgnoreCase))
                        {
                            DailyOffer();

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

                        }
                        else if (choiceM.Equals("B", StringComparison.OrdinalIgnoreCase))


                        {
                            SpecialOffer();

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

                        }
                        else if (choiceM.Equals("f", StringComparison.OrdinalIgnoreCase) || choiceM.Equals("d", StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("menu f en d test test");
                            csvtest.CSVTEST();
                            Console.WriteLine("einde menu f en d joehoe");
                            
                            

                        }
                        
                        else if (string.IsNullOrEmpty(choiceM))
                        {   //EMPTY INPUT
                            Console.WriteLine("Not a valid input, please try again.");
                        }
                        else
                        {   //INVALID INPUT
                            Console.WriteLine("Not a valid input, please try again.");
                        }

                        backgo();

                        void backgo()
                        {


                            Console.Write("\nDo you want to go back?[yes/no]");
                            string goback = Console.ReadLine();

                            if (goback.Equals("yes", StringComparison.OrdinalIgnoreCase))
                            {
                                Menu();
                            }
                            else if (goback.Equals("no", StringComparison.OrdinalIgnoreCase))
                            {
                                Console.Write("\nWhat do you want to do?");
                            }
                            else
                            {
                                Console.WriteLine("Not a valid input, please try again.");
                                backgo();
                            }
                        }
                    }
                }
            }
        }

    }
}