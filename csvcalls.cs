using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace projectb
{
    public class csvcalls
    {
        static bool changeRun = true;
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
            changeRun = true;
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
                    CHANGEcsv();
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
            Console.WriteLine("NR??: ");
            string nr4 = Console.ReadLine();
            Console.WriteLine("NR11: ");
            string nr1 = Console.ReadLine();
            Console.WriteLine("NR22: ");
            string nr2 = Console.ReadLine();
            Console.WriteLine("NR33: ");
            string nr3 = Console.ReadLine();
            string eind = "\""+ nr4 + " \";\"" + nr1 + ":  \"" + ";\"" + nr2 + " \";\"" + nr3 + " \"";


            string pathstring = Directory.GetCurrentDirectory() + "/../../../csv_files/Drinks.csv";
            var csvread = File.ReadAllText(pathstring);
            using (StreamWriter sw = File.AppendText(pathstring))
            {

                sw.WriteLine(eind);
                //hier iets zodat het erop lijkt??????
            }
            DRINKS();

            //>>>>>> NOG TESTEN DEZE HIERONDER <<<<<<
            //Chilkat.Csv csv = new Chilkat.Csv();

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

            //Delete
            String GetAddress(String searchName)
            {
                var strLines = File.ReadLines(pathstring);
                foreach(var line in strLines)
                {
                    if (line.Split(',')[1].Equals(searchName))
                        return line.Split(',')[2];
                }
                return "";
            }

            String peterAddress = GetAddress("Heineken");
        }

    }
}
