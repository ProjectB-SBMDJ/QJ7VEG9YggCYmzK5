using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json.Linq;
using projectb;


namespace projectb
{
    public class csvcalls
    {

        private static string reservationsDatabase = Directory.GetCurrentDirectory() + "/../../../allMenu.json";
        static bool changeRun = true;
        private static string pathstring;
        private static IEnumerable<object> file;

        public static void DRINKS()
        {
            var json = File.ReadAllText(reservationsDatabase);
            try
            {
                var jObject = JObject.Parse(json);

                if (jObject != null)
                {
                    JArray reservationsArray = (JArray)jObject["Drinks"];
                    if (reservationsArray != null)
                    {
                        foreach (var item in reservationsArray)
                        {
                            Console.WriteLine("NR.: " + item["nr"].ToString() + "    Sort: " + item["sort"].ToString() + "   Name: " + item["name"].ToString() + "   Price: " + item["price"].ToString() + " Euro's"); ;
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void DAILYOFFERS()
        {
            var date = DateTime.Now;
            string a = date.ToString("dddd");

            var json = File.ReadAllText(reservationsDatabase);
            try
            {
                if (a.Equals("Monday", StringComparison.OrdinalIgnoreCase))

                {
                    var jObject = JObject.Parse(json);

                    if (jObject != null)
                    {
                        {
                            JArray reservationsArray = (JArray)jObject["Monday"];

                            if (reservationsArray != null)
                            {
                                foreach (var item in reservationsArray)
                                {
                                    Console.WriteLine("NR.: " + item["nr"].ToString() + "    Sort: " + item["sort"].ToString() + "   Name: " + item["name"].ToString() + "   Price: " + item["price"].ToString() + " Euro's"); ;
                                }

                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            try
            {
                if (a.Equals("Tuesday", StringComparison.OrdinalIgnoreCase))

                {
                    var jObject = JObject.Parse(json);

                    if (jObject != null)
                    {
                        {
                            JArray reservationsArray = (JArray)jObject["Tuesday"];

                            if (reservationsArray != null)
                            {
                                foreach (var item in reservationsArray)
                                {
                                    Console.WriteLine("NR.: " + item["nr"].ToString() + "    Sort: " + item["sort"].ToString() + "   Name: " + item["name"].ToString() + "   Price: " + item["price"].ToString() + " Euro's"); ;
                                }

                            }
                        }
                    }
                }
            }

            catch (Exception)
            {

                throw;
            }
            try
            {
                if (a.Equals("Wednesday", StringComparison.OrdinalIgnoreCase))

                {
                    var jObject = JObject.Parse(json);

                    if (jObject != null)
                    {
                        {
                            JArray reservationsArray = (JArray)jObject["Wednesday"];

                            if (reservationsArray != null)
                            {
                                foreach (var item in reservationsArray)
                                {
                                    Console.WriteLine("NR.: " + item["nr"].ToString() + "    Sort: " + item["sort"].ToString() + "   Name: " + item["name"].ToString() + "   Price: " + item["price"].ToString() + " Euro's"); ;
                                }

                            }
                        }
                    }
                }
            }

            catch (Exception)
            {

                throw;
            }
            try
            {
                if (a.Equals("Thursday", StringComparison.OrdinalIgnoreCase))

                {
                    var jObject = JObject.Parse(json);

                    if (jObject != null)
                    {
                        {
                            JArray reservationsArray = (JArray)jObject["Thursday"];

                            if (reservationsArray != null)
                            {
                                foreach (var item in reservationsArray)
                                {
                                    Console.WriteLine("NR.: " + item["nr"].ToString() + "    Sort: " + item["sort"].ToString() + "   Name: " + item["name"].ToString() + "   Price: " + item["price"].ToString() + " Euro's"); ;
                                }

                            }
                        }
                    }
                }
            }

            catch (Exception)
            {

                throw;
            }
            try
            {
                if (a.Equals("Friday", StringComparison.OrdinalIgnoreCase))

                {
                    var jObject = JObject.Parse(json);

                    if (jObject != null)
                    {
                        {
                            JArray reservationsArray = (JArray)jObject["Friday"];

                            if (reservationsArray != null)
                            {
                                foreach (var item in reservationsArray)
                                {
                                    Console.WriteLine("NR.: " + item["nr"].ToString() + "    Sort: " + item["sort"].ToString() + "   Name: " + item["name"].ToString() + "   Price: " + item["price"].ToString() + " Euro's"); ;
                                }

                            }
                        }
                    }
                }
            }

            catch (Exception)
            {

                throw;
            }
            try
            {
                if (a.Equals("Saturday", StringComparison.OrdinalIgnoreCase))

                {
                    var jObject = JObject.Parse(json);

                    if (jObject != null)
                    {
                        {
                            JArray reservationsArray = (JArray)jObject["Saturday"];

                            if (reservationsArray != null)
                            {
                                foreach (var item in reservationsArray)
                                {
                                    Console.WriteLine("NR.: " + item["nr"].ToString() + "    Sort: " + item["sort"].ToString() + "   Name: " + item["name"].ToString() + "   Price: " + item["price"].ToString() + " Euro's"); ;
                                }

                            }
                        }
                    }
                }
            }

            catch (Exception)
            {

                throw;
            }
            try
            {
                if (a.Equals("Sunday", StringComparison.OrdinalIgnoreCase))

                {
                    var jObject = JObject.Parse(json);

                    if (jObject != null)
                    {
                        {
                            JArray reservationsArray = (JArray)jObject["Sunday"];

                            if (reservationsArray != null)
                            {
                                foreach (var item in reservationsArray)
                                {
                                    Console.WriteLine("NR.: " + item["nr"].ToString() + "    Sort: " + item["sort"].ToString() + "   Name: " + item["name"].ToString() + "   Price: " + item["price"].ToString() + " Euro's"); ;
                                }

                            }
                        }
                    }
                }
            }

            catch (Exception)
            {

                throw;
            }

        }



        public static void FOOD()
        {
            var json = File.ReadAllText(reservationsDatabase);
            try
            {
                var jObject = JObject.Parse(json);

                if (jObject != null)
                {
                    JArray reservationsArray = (JArray)jObject["Food"];
                    if (reservationsArray != null)
                    {
                        foreach (var item in reservationsArray)
                        {
                            Console.WriteLine("NR.: " + item["nr"].ToString() + "    Sort: " + item["sort"].ToString() + "   Name: " + item["name"].ToString() + "   Price: " + item["price"].ToString() + " Euro's"); ;
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void SPECIALS()
        {
            var json = File.ReadAllText(reservationsDatabase);
            try
            {
                var jObject = JObject.Parse(json);

                if (jObject != null)
                {
                    JArray reservationsArray = (JArray)jObject["Specials"];
                    if (reservationsArray != null)
                    {
                        foreach (var item in reservationsArray)
                        {
                            Console.WriteLine("NR.: " + item["nr"].ToString() + "    Sort: " + item["sort"].ToString() + "   Name: " + item["name"].ToString() + "  For only " + item["price"].ToString() + " Euro's"); ;
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static void CHANGEask()
        {
            Console.WriteLine("Which file would you like to read and change?\n" +
                "Choose from: Drinks, Food, Specials or Daily");
            string changeIN = Console.ReadLine();
            while (changeRun)
            {
                if (changeIN.Equals("Drinks", StringComparison.OrdinalIgnoreCase))
                {
                    changeRun = false;
                    DRINKS();
                    Console.WriteLine("hierna aanpassen en kiezen welke rij, column en artikel het moet worden...");
                    //CHANGEcsv();
                }
                else if (changeIN.Equals("Food", StringComparison.OrdinalIgnoreCase))
                {
                    changeRun = false;
                }
                else if (changeIN.Equals("Specials", StringComparison.OrdinalIgnoreCase))
                {
                    changeRun = false;
                }
                else if (changeIN.Equals("Daily", StringComparison.OrdinalIgnoreCase))
                {
                    changeRun = false;
                }
                else
                {
                    Console.WriteLine("Not a valid input, please try again.");
                }
            }

        }

      
           

            public static void addMenu()
            {
                var name = getName();
                var sort = getSort();
                var Nr = getNr();
                var Price = getPrice();
                string part = getPart();
                string resInput;

           
            //----------VARIABLES-----------------------------------------------------------------------------------------------
            string menuName;
            string menuSort;
            string menuNr;
            string menuPrice;
            string menuPart;

            //----------FUNCTIONS-----------------------------------------------------------------------------------------------

            //Get name for reservation.
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
            //Reads inputs for the reservation menu's options.
            void readMenuInput()
            {
                Console.Write(": ");
                menuName = Console.ReadLine();
            }

            if (resInput != "c")
            {
                var newMenu = "{ 'name': '" + name + "', 'sort': '" + sort + "', 'Nr': '" + Nr + "', 'Price': " + Price;
                try
                {
                    var json = File.ReadAllText(reservationsDatabase);
                    var jsonObj = JObject.Parse(json);
                    var reservationsArray = jsonObj.GetValue(part) as JArray;
                    var addMenu = JObject.Parse(newMenu);
                    reservationsArray.Add(addMenu);

                    jsonObj[part] = reservationsArray;
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
        }
    }



