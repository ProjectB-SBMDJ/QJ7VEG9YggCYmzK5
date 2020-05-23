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


        public static void CHANGEcsv()
        {
            //>>>>>> NOG TESTEN DEZE HIERONDER <<<<<<
            // Chilkat.Csv csv = new Chilkat.Csv();

            //  Prior to loading the CSV file, indicate that the 1st row
            //  should be treated as column names:
            // csv.HasColumnNames = true;

            //  Load the CSV records from the file:
            //  success = csv.LoadFile("sample.csv");


            //  Change "cheese" to "baguette"
            //  "cheese" is at row=0, column=3
            //success = csv.SetCell(0, 3, "baguette");

            //  Write the updated CSV to a string and display:
            //     string csvDoc;
            //     csvDoc = csv.SaveToString();
            //    Console.WriteLine(csvDoc);

            //  Save the CSV to a file:
            //   success = csv.SaveFile("out.csv");
            //hier dan dezelfde weer als savefile?
        }

    }
}
