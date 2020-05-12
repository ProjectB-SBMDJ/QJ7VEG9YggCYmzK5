using System;
using System.Collections.Generic;
using System.IO;


namespace projectb
{
    public class csvcalls
    {
        static bool changeRun = true;
        private static string pathstring;
        private static IEnumerable<object> file;

        public static void DRINKS()
        {
            string pathstring = Directory.GetCurrentDirectory() + "/../../../csv_files/Drinks.csv";
            var csvread = File.ReadAllText(pathstring);
            String[] file = csvread.Split(new char[] { '"', ';' }, StringSplitOptions.RemoveEmptyEntries);
         
            foreach (var i in file)
            {
               Console.Write(i);
            }
        }

        public static void DAILYOFFERS()
        {
            var date = DateTime.Now;
            string a = date.ToString("dddd");

            if (a.Equals("Monday", StringComparison.OrdinalIgnoreCase))
            {
                string pathstring = Directory.GetCurrentDirectory() + "/../../../csv_files/DailyMon.csv";
                var csvread = File.ReadAllText(pathstring);
                String[] file = csvread.Split(new char[] { '"', ';' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var i in file)
                {
                    Console.Write(i);
                }
            }

            else if (a.Equals("Tuesday", StringComparison.OrdinalIgnoreCase))
            {
                string pathstring = Directory.GetCurrentDirectory() + "/../../../csv_files/DailyDi.csv";
                var csvread = File.ReadAllText(pathstring);
                String[] file = csvread.Split(new char[] { '"', ';' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var i in file)
                {
                    Console.Write(i);
                }
            }

            else if (a.Equals("Wednesday", StringComparison.OrdinalIgnoreCase))
            {
                string pathstring = Directory.GetCurrentDirectory() + "/../../../csv_files/DailyWo.csv";
                var csvread = File.ReadAllText(pathstring);
                String[] file = csvread.Split(new char[] { '"', ';' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var i in file)
                {
                    Console.Write(i);
                }
            }

            else if (a.Equals("Thursday", StringComparison.OrdinalIgnoreCase))
            {
                string pathstring = Directory.GetCurrentDirectory() + "/../../../csv_files/DailyDo.csv";
                var csvread = File.ReadAllText(pathstring);
                String[] file = csvread.Split(new char[] { '"', ';' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var i in file)
                {
                    Console.Write(i);
                }
            }

            else if (a.Equals("Friday", StringComparison.OrdinalIgnoreCase))
            {
                string pathstring = Directory.GetCurrentDirectory() + "/../../../csv_files/DailyFri.csv";
                var csvread = File.ReadAllText(pathstring);
                String[] file = csvread.Split(new char[] { '"', ';' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var i in file)
                {
                    Console.Write(i);
                }
            }

            else if (a.Equals("Saturday", StringComparison.OrdinalIgnoreCase))
            {
                string pathstring = Directory.GetCurrentDirectory() + "/../../../csv_files/DailySa.csv";
                var csvread = File.ReadAllText(pathstring);
                String[] file = csvread.Split(new char[] { '"', ';' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var i in file)
                {
                    Console.Write(i);
                }
            }

            else if (a.Equals("Sunday", StringComparison.OrdinalIgnoreCase))
            {
                string pathstring = Directory.GetCurrentDirectory() + "/../../../csv_files/DailySu.csv";
                var csvread = File.ReadAllText(pathstring);
                String[] file = csvread.Split(new char[] { '"', ';' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var i in file)
                {
                    Console.Write(i);
                }
            }


        }

        public static void FOOD()
        {
            string pathstring = Directory.GetCurrentDirectory() + "/../../../csv_files/Food.csv";
            var csvread = File.ReadAllText(pathstring);
            String[] file = csvread.Split(new char[] { '"', ';' }, StringSplitOptions.RemoveEmptyEntries);
           

            foreach (var i in file)
            {
                Console.Write(i);
            }
        }
        public static void SPECIALS()
        {
            string pathstring = Directory.GetCurrentDirectory() + "/../../../csv_files/Specials.csv";
            var csvread = File.ReadAllText(pathstring);
            String[] file = csvread.Split(new char[] { '"', ';' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var i in file)
            {
                Console.Write(i);
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
