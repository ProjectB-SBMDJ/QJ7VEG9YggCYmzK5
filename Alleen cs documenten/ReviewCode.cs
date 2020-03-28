using System;
using System.Collections.Generic;

namespace testproject1
{
    public class ReviewCode
    {
        //static = om het global te maken in de hele class
        static bool QA1;    //for the read question loop
        static bool QA2;    //for the ask question loop
        static bool QA3;    //for the like loop
        static string readQA;
        static string nameIn;
        

        static Dictionary<string, string> reviewsDict = new Dictionary<string, string>(){
            {"John", "Very nice place!"},
            {"Marie", "Loved the people and the food. Staff was very friendly." },
            {"Paul", "This was a lovely experience."} }; 
        static int likes = 30;

        //---------------------WRITTEN REVIEW MENU------------------------
        public static void AskRev()
        {
            QA1 = true;
            //for the question loop below
            while (QA1)
            {
                Console.WriteLine("Do you want to read the reviews? [Yes] / [No]");
                readQA = Console.ReadLine();
                if (readQA.Equals("yes", StringComparison.OrdinalIgnoreCase))
                {
                    QA1 = false;
                    ReadRevs();
                }
                else if (readQA.Equals("no", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("You chose no, so you will go back to the main review menu.");
                    QA1 = false;
                }
                else
                {
                    Console.WriteLine("Not a valid input, please try again.");
                }
            }

        }

        //---------------------READ WRITTEN REVIEWS------------------------
        public static void ReadRevs()
        {
            QA2 = true;
            //for the question loop below
            Console.WriteLine("~~ Written reviews ~~");
            Console.WriteLine("Total number of reviews: {0}", reviewsDict.Count);

            foreach (KeyValuePair<string, string> i in reviewsDict)
            {
                Console.WriteLine("Name: {0} \n Review: {1} \n",
                    i.Key, i.Value);
            }
            //print all items in the reviews dictionary

            while (QA2)
            {
                Console.WriteLine("Do you want to write a review? [Yes] / [No]");
                readQA = Console.ReadLine();
                if (readQA.Equals("yes", StringComparison.OrdinalIgnoreCase))
                {
                    QA2 = false;
                    WriteRevs();
                }
                else if (readQA.Equals("no", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("You chose no, so you will be guided back to the first question of the written reviews page.");
                    QA2 = false;
                    AskRev();
                }
                else
                {
                    Console.WriteLine("Not a valid input, please try again.");
                }

            }
        }

        //---------------------WRITE REVIEWS------------------------
        public static void WriteRevs()
        {
            Console.WriteLine("~~ Write an review ~~");
            Console.Write("Write your name here: ");
            nameIn = Console.ReadLine();
            Console.Write("Write your review here: ");
            string reviewIn = Console.ReadLine();

            Console.WriteLine("\nYour review:\nName: " + nameIn + "\nReview: " + reviewIn);
            reviewsDict.Add(nameIn, reviewIn);

            Console.WriteLine("\nThank you for your review! You will now be guided back to the first question of the written reviews page.");
            AskRev();
        }


        //---------------------LIKES------------------------
        public static void LikeRevs()
        {
            QA3 = true;
            //for the like loop below
            Console.WriteLine("--- The number of likes is " + likes + " ---");
            while (QA3)
            {
                Console.WriteLine("Do you want to give this restaurant a LIKE? [Yes] / [No]");
                readQA = Console.ReadLine();
                if (readQA.Equals("yes", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Thank you for your like!");
                    likes += 1; //total number of likes goes up by one
                    Console.Write("The number of likes is now " + likes + ".");
                    Console.WriteLine(" You will be guided back to the main review menu.");
                    QA3 = false;
                }
                else if (readQA.Equals("no", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("You chose no, so you will be guided back to the main review menu.");
                    QA3 = false;
                }
                else
                {
                    Console.WriteLine("Not a valid input, please try again.");
                }
            }
        }

    }
}


