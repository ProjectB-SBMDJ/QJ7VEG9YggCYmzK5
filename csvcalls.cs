using System;
using System.IO;

namespace projectb
{
    public class csvcalls
    {
        static bool changeRun = true;
        public static void DRINKS()
        {
            string pathstring = "/Users/danine/Documents/School/Programmas/GitHub/QJ7VEG9YggCYmzK5/Drinks.csv";
            var csvread = File.ReadAllText(pathstring);
            String[] file = csvread.Split(new char[] { '"', ';' }, StringSplitOptions.RemoveEmptyEntries);
         
            foreach (var i in file)
            {
               Console.Write(i);
            }
        }
        public static void FOOD()
        {
            string pathstring = "/Users/danine/Documents/School/Programmas/GitHub/QJ7VEG9YggCYmzK5/Food.csv";
            var csvread = File.ReadAllText(pathstring);
            String[] file = csvread.Split(new char[] { '"', ';' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var i in file)
            {
                Console.Write(i);
            }
        }
        public static void SPECIALS()
        {
            string pathstring = "/Users/danine/Documents/School/Programmas/GitHub/QJ7VEG9YggCYmzK5/Specials.csv";
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
