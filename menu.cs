using System;
using System.IO;
using System.Linq;
using Newtonsoft.Json.Linq;
using projectb;

namespace testproject1 {

    public class Menu
    {
        private static string menuDatabase = Directory.GetCurrentDirectory() + "/../../../json_files/allMenu.json";


        public static void menu()
        {
            bool chosen = true;

            void ColoredConsoleWriteLine(ConsoleColor color, string text) {
                ConsoleColor originalColor = Console.ForegroundColor;
                Console.ForegroundColor = color;
                Console.WriteLine(text);
                Console.ForegroundColor = originalColor;
            }

            void ColoredConsoleWrite(ConsoleColor color, string text) {
                ConsoleColor originalColor = Console.ForegroundColor;
                Console.ForegroundColor = color;
                Console.Write(text);
                Console.ForegroundColor = originalColor;
            }

            string ToUpperFirstLetter(string source) {
                if (string.IsNullOrEmpty(source))
                    return string.Empty;
                // convert to char array of the string
                char[] letters = source.ToCharArray();
                // upper case the first char
                letters[0] = char.ToUpper(letters[0]);
                // return the array made of the new char array
                return new string(letters);
            }
            // day today
            var date = DateTime.Now;
            string a = date.ToString("dddd");
            ColoredConsoleWriteLine(ConsoleColor.Blue, "Welcome to the menu");
            if (AdminSystem.adminLoggedin == true) {
                Console.WriteLine(" [DO] - Daily offers \n [S] - Special offers\n [F] - Food\n [D] - Drink\n [AM] - Add Menu\n [E] - Exit");
            } else {
                Console.WriteLine(" [DO] - Daily offers \n [S] - Special offers\n [F] - Food\n [D] - Drink\n [E] - Exit");
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

            }

            void AddMenu(string menuType) {
                menuType = ToUpperFirstLetter(menuType);
                Console.WriteLine("Enter Dish/Drink Name: ");
                var dishName = Console.ReadLine();
                Console.WriteLine("Enter Dish/Drink Sort: ");
                var dishSort = Console.ReadLine();
                Console.WriteLine("Enter Dish/Drink Price: ");
                var dishPrice = Console.ReadLine();

                var newMenuItem = "{ 'name': '" + dishName + "', 'price': '" + dishPrice + "', 'sort': '" + dishSort + "'}";
                try {
                    var json = File.ReadAllText(menuDatabase);
                    var jsonObj = JObject.Parse(json);
                    var menuArray = jsonObj.GetValue(menuType.ToString()) as JArray;
                    var newMenu = JObject.Parse(newMenuItem);
                    menuArray.Add(newMenu);

                    jsonObj[menuType] = menuArray;
                    string newJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj,
                                           Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(menuDatabase, newJsonResult);
                } catch (Exception ex) {
                    Console.WriteLine("Add Error : " + ex.Message.ToString());
                }
                Console.Write("Menu has been updated...");
                System.Threading.Thread.Sleep(3000);
                Console.Clear();
                ColoredConsoleWriteLine(ConsoleColor.Red, "Welcome to Restaurant DaVinci!");
                Console.WriteLine(
                    "[1] - Reviews" +
                    "\n[2] - Reservations" +
                    "\n[3] - Our Menu" +
                    "\n[E] - Close Application"
                );
            }

            //void deleteMenu(string menuType) {
            //    menuType = ToUpperFirstLetter(menuType);
            //    var json = File.ReadAllText(menuDatabase);
            //    try {
            //        var jObject = JObject.Parse(json);
            //        JArray menuArray = (JArray)jObject[menuType];
            //        Console.Write("\nEnter Name of the Dish/Drink you would like to delete ([C] to cancel): ");
            //        var readResCode = Console.ReadLine();
            //        Console.Clear();

            //        if (readResCode != "c") {
            //            var readName = Console.ReadLine();
            //            if (readName != null && json.ToString().Contains(readName.ToString())) {
            //                var name = string.Empty;
            //                var resToDeleted = menuArray.FirstOrDefault(obj => obj["name"].Value<string>() == readName);

            //                menuArray.Remove(resToDeleted);

            //                string output = Newtonsoft.Json.JsonConvert.SerializeObject(jObject, Newtonsoft.Json.Formatting.Indented);
            //                File.WriteAllText(menuDatabase, output);
            //                Console.WriteLine("Menu Item has been deleted...");
            //                System.Threading.Thread.Sleep(1500);
            //                Console.Clear();
            //                //menuHelp();
            //            } else {
            //                Console.WriteLine("Reservation not found, please try again");
            //                deleteMenu(menuType);
            //            }
            //            if (readResCode == "c") {
            //                Console.Clear();
            //                menu();

            //            } else {
            //                Console.Write("Invalid Reservation Code, Try Again!\n");
            //                deleteMenu(menuType);
            //            }
            //        } else {
            //            //menuHelp();
            //        }

            //    } catch (Exception) {

            //        throw;
            //    }
            //}

            while (chosen)
            {
                Console.Write("\n: ");
                string choiceM = Console.ReadLine();

                if (choiceM.Equals("am", StringComparison.OrdinalIgnoreCase) && AdminSystem.adminLoggedin == true) {
                    chosen = false;
                    Console.Clear();
                    Console.WriteLine("Which menu would you like to add to? (Food, Drinks, Specials)");
                    string menuTypeIn = Console.ReadLine();
                    AddMenu(menuTypeIn);
                    //csvcalls.addMenu();
                } else if (choiceM.Equals("dm", StringComparison.OrdinalIgnoreCase) && AdminSystem.adminLoggedin == true) {
                    chosen = false;
                    Console.Clear();
                    Console.WriteLine("Which menu would you like to delete from? (Food, Drinks, Specials)");
                    string menuTypeIn = Console.ReadLine();
                    //deleteMenu(menuTypeIn);
                    //csvcalls.addMenu();
                } else if (choiceM.Equals("do", StringComparison.OrdinalIgnoreCase)) {
                    chosen = false;
                    Console.Clear();
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
                    backgo();
                    //csvcalls.DAILYOFFERS(); //get to the csv file DAILYOFFERS

                } else if (choiceM.Equals("s", StringComparison.OrdinalIgnoreCase)) {
                    chosen = false;
                    Console.Clear();
                    Console.WriteLine("*** Welcome to the Special Offers ***************");
                    viewMenu("Specials");
                    backgo();
                    //csvcalls.SPECIALS(); //get to the csv file specials

                } else if (choiceM.Equals("f", StringComparison.OrdinalIgnoreCase)) {
                    chosen = false;
                    Console.Clear();
                    Console.WriteLine("*** Welcome to the Food Menu ***");
                    viewMenu("Food");
                    backgo();
                    //csvcalls.FOOD(); //get to the csv file food
                } else if (choiceM.Equals("d", StringComparison.OrdinalIgnoreCase)) {
                    chosen = false;
                    Console.Clear();
                    Console.WriteLine("*** Welcome to the Drinks ***");
                    viewMenu("Drinks");
                    backgo();
                    //csvcalls.DRINKS(); //get to the csv file drinks
                } else if (choiceM.Equals("111", StringComparison.OrdinalIgnoreCase)) {
                    //Dit is nog hier, maar dit moet naar het admin dingetje verplaats worden zodra hij klaar is
                    chosen = false;
                    Console.Clear();
                    Console.WriteLine("*aanpassen*");
                    //csvcalls.CHANGEask();
                } else if (choiceM.Equals("E", StringComparison.OrdinalIgnoreCase)) {
                    chosen = false;
                    Console.Clear();
                    ColoredConsoleWriteLine(ConsoleColor.Red, "Welcome to Restaurant DaVinci!");
                    Console.WriteLine(
                        "[1] - Reviews" +
                        "\n[2] - Reservations" +
                        "\n[3] - Our Menu" +
                        "\n[E] - Close Application"
                    );
                } else if (string.IsNullOrEmpty(choiceM)) {   //EMPTY INPUT
                    Console.WriteLine("Not a valid input, please try again.");
                } else {   //INVALID INPUT
                    Console.WriteLine("Not a valid input, please try again.");
                }
            }

            void backgo() {
                chosen = false;

                Console.WriteLine("\nDo you want to go back to the main menu?[yes/no]");
                string goback = Console.ReadLine();

                if (goback.Equals("no", StringComparison.OrdinalIgnoreCase)) {
                    menu();
                } else if (goback.Equals("yes", StringComparison.OrdinalIgnoreCase)) {
                    Console.Clear();
                    ColoredConsoleWriteLine(ConsoleColor.Red, "Welcome to Restaurant DaVinci!");
                    Console.WriteLine(
                        "[1] - Reviews" +
                        "\n[2] - Reservations" +
                        "\n[3] - Our Menu" +
                        "\n[E] - Close Application"
                    );
                    Console.Write("\n: ");
                } else {
                    Console.WriteLine("Not a valid input, please try again.");
                    backgo();
                }
            }
        }

    }
}