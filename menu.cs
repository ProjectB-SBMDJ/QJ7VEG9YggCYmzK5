using System;
using System.IO;
using System.Linq;
using Newtonsoft.Json.Linq;
using projectb;

namespace testproject1
{

    public class Menu
    {
        static bool chosen = true;
        private static string reservationsDatabase = Directory.GetCurrentDirectory() + "/../../../allMenu.json";

        public static void menusystem()
        {


            //----------VARIABLES-----------------------------------------------------------------------------------------------
            string menuName;
            string menuSort;
            string menuNr;
            string menuPrice;
            string menuPart;
            string resInput;

            string getPart()
            {
                Console.Write("Please enter the part of the menu ([C] to cancel): ");
                menuPart = Console.ReadLine();
                resInput = menuPart;
                while (string.IsNullOrEmpty(menuPart))
                {
                    Console.WriteLine("Empty input, Please try again");
                    menuPart = Console.ReadLine();
                }
                return menuPart;
            }

            //Get name for reservation.
            string getName()
            {
                Console.Write("Please enter the name of the menu ([C] to cancel): ");
                menuName = Console.ReadLine();
                resInput = menuName;
                while (string.IsNullOrEmpty(menuName))
                {
                    Console.WriteLine("Empty input, Please try again");
                    menuName = Console.ReadLine();
                }
                return menuName;
            }

            //Get date of reservation
            string getSort()
            {
                if (resInput != "c")
                {
                    Console.Write("Please enter the sort of the menu: ");
                    menuSort = Console.ReadLine();
                    while (string.IsNullOrEmpty(menuSort))
                    {
                        Console.Write("Empty input, please try again: ");
                        menuSort = Console.ReadLine();
                    }
                }
                else
                {
                    menuSort = "_";
                }
                return menuSort;
            }

            //Get time for reservation.
            string getNr()
            {
                if (resInput != "c")
                {
                    Console.Write("Please enter the Nr. of the menu: ");
                    menuNr = Console.ReadLine();
                    while (string.IsNullOrEmpty(menuNr))
                    {
                        Console.Write("Empty input, please try again: ");
                        menuNr = Console.ReadLine();
                    }
                }
                else
                {
                    menuNr = "_";
                }
                return menuNr;
            }

            //Get amount of guests for reservation.
            string getPrice()
            {
                if (resInput != "c")
                {
                    Console.Write("Please enter the price of the menu: ");
                    menuPrice = Console.ReadLine();
                    while (string.IsNullOrEmpty(menuPrice))
                    {
                        Console.Write("Empty input, Please try again: ");
                        menuPrice = Console.ReadLine();
                    }
                }
                else
                {
                    menuPrice = "_";
                }
                return menuPrice;
            }

            void readMenuInput()
            {
                Console.Write(": ");
                menuName = Console.ReadLine();
            }

            void addMenu()
            {
                var name = getName();
                var sort = getSort();
                var Nr = getNr();
                var Price = getPrice();
                string part = getPart();

                if (resInput != "c")
                {
                    var newMenu = "{ 'name': '" + name + "', 'sort': '" + sort + "', 'Nr': '" + Nr + "', 'Price': " + Price;
                    try
                    {
                        var json = File.ReadAllText(reservationsDatabase);
                        var jsonObj = JObject.Parse(json);
                        var MenuArray = jsonObj.GetValue(menuPart) as JArray;
                        var addMenu = JObject.Parse(newMenu);
                        MenuArray.Add(menuPart);

                        jsonObj[part] = MenuArray;
                        string newJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj,
                                               Newtonsoft.Json.Formatting.Indented);
                        File.WriteAllText(reservationsDatabase, newJsonResult);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Add Error : " + ex.Message.ToString());
                    }

                    Console.Clear();
                    Console.WriteLine("Menu Saved... Your menu code is: " + Nr);
                    System.Threading.Thread.Sleep(3000);
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                }
            }

            void menu()
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
                        addMenu();
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

            void backgo()
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
            }

        }
    }
}
