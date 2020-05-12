using System;
using System.Collections.Generic;

namespace testproject1
{
    public class StarReviews
    {

        static bool QA6;    //for the star menu loop
        static bool QA7;    //for the star number loop
        static bool QA8;    //for the star write loop
        static bool QA9;    //for the name input loop
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
            QA6 = true;
                //for the question loop below
            while (QA6)
            {
                Console.WriteLine("Do you want to see all the star reviews? [Yes] / [No]");
                readQAstar = Console.ReadLine();
                if (readQAstar.Equals("yes", StringComparison.OrdinalIgnoreCase))
                {
                    QA6 = false;
                    StarRead();
                }
                else if (readQAstar.Equals("no", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("You chose no, so you will go back to the main review menu.");
                    QA6 = false;
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
            QA8 = true;
            Console.WriteLine("Total number of reviews: {0}", starRevsDict.Count);
            foreach (KeyValuePair<string, string> i in starRevsDict)
            {
                Console.WriteLine("Name: {0} \n Review: {1} \n",
                    i.Key, i.Value);
            }

            while (QA8)
            {


                Console.WriteLine("Do you want to write a review? [Yes] / [No]");
                readQAstar = Console.ReadLine();
                if (readQAstar.Equals("yes", StringComparison.OrdinalIgnoreCase))
                {
                    WriteStarRevs();
                    QA8 = false;
                }
                else if (readQAstar.Equals("no", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("You chose no, so you will be guided back to the first question of the star reviews page.");
                    QA8 = false;
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
            QA7 = true;//for the number loop below
            QA9 = true; //for the name input
            starsIn = "";
            Console.WriteLine("~~ Leave an star review ~~");
            while (QA9)
            {
                Console.Write("Write your name here: ");
                nameIn = Console.ReadLine();
                if (string.IsNullOrEmpty(nameIn))
                {
                    Console.WriteLine("Empty input, please try again.");
                }
                else
                {
                    QA9 = false;
                }
            }


            while (QA7)
            {
                Console.Write("How much stars would you like to give? ");
                var starsNrIn = Console.ReadLine();
                if (string.IsNullOrEmpty(starsNrIn))
                {
                    Console.WriteLine("Empty input, please try again.");
                }
                else
                {
                    char starsNrchar = starsNrIn[0];                //string to char
                    bool starsNrTF = Char.IsDigit(starsNrchar);     //check if char is digit

                    if (starsNrTF)  //if the input is a number
                    {
                        var starNR = int.Parse(starsNrIn);          //char to int
                        if (starNR > 0 && starNR <= 5)      //only 1 to 5 stars
                        {
                            for (int i = starNR; i > 0; i--)
                            {
                                starsIn += "★ ";        //create the strings with spaces in between
                            }
                            QA7 = false; //stop the loop
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

            }
            Console.WriteLine("\nYour review:\nName: " + nameIn + "\nReview: " + starsIn);
            starRevsDict.Add(nameIn, starsIn);

            Console.WriteLine("\nThank you for your review! You will now be guided back to the first question of the star reviews page.");
            StarRevMenu();
        }

    }
}
