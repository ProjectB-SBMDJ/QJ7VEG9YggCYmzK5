using System;
using System.Collections.Generic;

namespace testproject1
{
    public class StarReviews
    {

        static bool QA4;    //for the star menu loop
        static bool QA5;    //for the star number loop
        static bool QA6;    //for the star write loop
        static string starsIn; //for the star strings
        static string readQAstar;
        static string nameIn;
  
        static Dictionary<string, string> starRevsDict = new Dictionary<string, string>(){
            {"Lola", "★ ★ ★ ★"},
            {"Henry", "★ ★ ★ ★ ★" },
            {"Dirk", "★ ★ ★"} };

        //---------------------STAR REVIEWS MENU------------------------
        public static void StarRevMenu()
        {
            QA4 = true;
                //for the question loop below

            while (QA4)
            {
                Console.WriteLine("Do you want to see all the star reviews? [Yes] / [No]");
                readQAstar = Console.ReadLine();
                if (readQAstar.Equals("yes", StringComparison.OrdinalIgnoreCase))
                {
                    QA4 = false;
                    StarRead();
                }
                else if (readQAstar.Equals("no", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("You chose no, so you will go back to the main review menu.");
                    QA4 = false;
                }
                else
                {
                    Console.WriteLine("Not a valid input, please try again.");
                }
            }

        }

        //---------------------READ STAR REVIEWS------------------------
        public static void StarRead()
        {
            QA6 = true;
            Console.WriteLine("Total number of reviews: {0}", starRevsDict.Count);
            foreach (KeyValuePair<string, string> i in starRevsDict)
            {
                Console.WriteLine("Name: {0} \n Review: {1} \n",
                    i.Key, i.Value);
            }

            while (QA6)
            {
                Console.WriteLine("Do you want to write a review? [Yes] / [No]");
                readQAstar = Console.ReadLine();
                if (readQAstar.Equals("yes", StringComparison.OrdinalIgnoreCase))
                {
                    WriteStarRevs();
                    QA6 = false;
                }
                else if (readQAstar.Equals("no", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("You chose no, so you will be guided back to the first question of the written reviews page.");
                    QA6 = false;
                    StarRevMenu();
                }
                else
                {
                    Console.WriteLine("Not a valid input, please try again.");
                }

            }

        }

        //---------------------WRITE STAR REVIEW------------------------
        public static void WriteStarRevs()
        {
            QA5 = true;
            //for the number loop below
            starsIn = "";
            Console.WriteLine("~~ Leave an star review ~~");
            Console.Write("Write your name here: ");
            nameIn = Console.ReadLine();
            

            while (QA5)
            {
                Console.Write("How much stars would you like to give? ");
                var starsNrIn = Console.ReadLine();
                char starsNrchar = starsNrIn[0];                //string to char
                bool starsNrTF = Char.IsDigit(starsNrchar);     //check if char is digit

                if (starsNrTF){
                    var starNR = int.Parse(starsNrIn);          //char to int
                    if (starNR > 0 && starNR <= 5)      //only 1 to 5 stars
                    {
                        for (int i = starNR; i > 0; i--)
                        {
                            starsIn += "★ ";        //create the strings with spaces in between
                        }
                        QA5 = false; //stop the loop
                    }
                    else
                    {
                        Console.WriteLine("You can only give 1 to 5 stars, please try again.");
                    }

                }
                else 
                {
                    Console.WriteLine("\'" + starsNrIn + "\' is not a number, please try again.");
                }


            }
            Console.WriteLine("\nYour review:\nName: " + nameIn + "\nReview: " + starsIn);
            starRevsDict.Add(nameIn, starsIn);

            Console.WriteLine("\nThank you for your review! You will now be guided back to the first question of the star reviews page.");
            StarRevMenu();
        }

    }
}
