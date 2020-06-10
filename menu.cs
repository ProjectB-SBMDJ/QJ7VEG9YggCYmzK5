using System;
using System.IO;
using Newtonsoft.Json.Linq;
using projectb;

namespace testproject1 {

    public class Menu
    {
        private static string menuDatabase = Directory.GetCurrentDirectory() + "/../../../json_files/allMenu.json";
        static bool chosen = true;
        public static void menu()
        {
            // day today
            var date = DateTime.Now;
            string a = date.ToString("dddd");
            Console.WriteLine("-------------------------------\n|     Welcome to the menu     |\n-------------------------------");
            if (AdminSystem.adminLoggedin == true) {
                Console.WriteLine(" [DO] - Daily offers \n [S] - Special offers\n [F] - Food\n [D] - Drink\n [am] - Add Menu");
            } else {
                Console.WriteLine(" [DO] - Daily offers \n [S] - Special offers\n [F] - Food\n [D] - Drink");
            }

            void viewMenu(string menuType)
            {
                var json = File.ReadAllText(menuDatabase);
                try
                {
                    var jObject = JObject.Parse(json);

                    if (jObject != null)
                    {
                        JArray menuArray = (JArray)jObject[menuType];
                        if (menuArray != null)
                        {
                            foreach (var item in menuArray)
                            {
                                Console.WriteLine("Name: " + item["name"].ToString() + "   Sort: " + item["sort"].ToString() + "   Price: " + item["price"].ToString());
                            }
                        }
                    }
                }
                catch (Exception)
                {

                    throw;
                }

                //Console.WriteLine("\n[C] - Go Back to Menu");
            }

            void AddMenu(string menuType) {
                Console.WriteLine("Enter Dish Name : ");
                var dishName = Console.ReadLine();
                Console.WriteLine("\nEnter Dish Sort : ");
                var dishSort = Console.ReadLine();
                Console.WriteLine("Enter Dish Price: ");
                var dishPrice = Console.ReadLine();

                var newMenuItem = "{ 'name': '" + dishName + "', 'price': '" + dishPrice + "', 'sort': '" + dishSort + "'}";
                try {
                    var json = File.ReadAllText(menuDatabase);
                    var jsonObj = JObject.Parse(json);
                    var menuArray = jsonObj.GetValue(menuType) as JArray;
                    var newMenu = JObject.Parse(newMenuItem);
                    menuArray.Add(newMenu);

                    jsonObj[menuType] = menuArray;
                    string newJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj,
                                           Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(menuDatabase, newJsonResult);
                } catch (Exception ex) {
                    Console.WriteLine("Add Error : " + ex.Message.ToString());
                }
            }

            while (chosen)
            {
                Console.Write("Choose an option: ");
                string choiceM = Console.ReadLine();
                if (AdminSystem.adminLoggedin == true) {
                    if (choiceM.Equals("am", StringComparison.OrdinalIgnoreCase)) {
                        chosen = false;
                        Console.WriteLine("Which menu would you like to add to? (Food, Drinks, Specials)");
                        string menuTypeIn = Console.ReadLine();
                        AddMenu(menuTypeIn);
                        //csvcalls.addMenu();
                    }
                }
                if (choiceM.Equals("do", StringComparison.OrdinalIgnoreCase)) {
                    chosen = false;
                    Console.WriteLine("*** Welcome to the Daily Offers ***");
                    Console.WriteLine("     " + date.ToLongDateString());
                    DateTime today = DateTime.Today;
                    if (today.DayOfWeek == DayOfWeek.Monday) {
                        viewMenu("Monday");
                    } else if (today.DayOfWeek == DayOfWeek.Tuesday) {
                        viewMenu("Tuesday");
                    } else if (today.DayOfWeek == DayOfWeek.Wednesday) {
                        viewMenu("Wednesday");
                    } else if (today.DayOfWeek == DayOfWeek.Thursday) {
                        viewMenu("Thursday");
                    } else if (today.DayOfWeek == DayOfWeek.Friday) {
                        viewMenu("Friday");
                    } else if (today.DayOfWeek == DayOfWeek.Saturday) {
                        viewMenu("Saturday");
                    } else if (today.DayOfWeek == DayOfWeek.Sunday) {
                        viewMenu("Sunday");
                    }
                    //csvcalls.DAILYOFFERS(); //get to the csv file DAILYOFFERS

                } else if (choiceM.Equals("s", StringComparison.OrdinalIgnoreCase)) {
                    chosen = false;
                    Console.WriteLine("*** Welcome to the Special Offers ***************");
                    viewMenu("Specials");
                    //csvcalls.SPECIALS(); //get to the csv file specials

                } else if (choiceM.Equals("f", StringComparison.OrdinalIgnoreCase)) {
                    chosen = false;
                    Console.WriteLine("*** Welcome to the Food Menu ***");
                    viewMenu("Food");
                    //csvcalls.FOOD(); //get to the csv file food
                } else if (choiceM.Equals("d", StringComparison.OrdinalIgnoreCase)) {
                    chosen = false;
                    Console.WriteLine("*** Welcome to the Drinks ***");
                    viewMenu("Drinks");
                    //csvcalls.DRINKS(); //get to the csv file drinks
                } else if (choiceM.Equals("111", StringComparison.OrdinalIgnoreCase)) {
                    //Dit is nog hier, maar dit moet naar het admin dingetje verplaats worden zodra hij klaar is
                    chosen = false;
                    Console.WriteLine("*aanpassen*");
                    //csvcalls.CHANGEask();
                } else if (string.IsNullOrEmpty(choiceM)) {   //EMPTY INPUT
                    Console.WriteLine("Not a valid input, please try again.");
                } else {   //INVALID INPUT
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