﻿using System;
using System.Collections.Generic;

namespace testproject1
{
    public class ReviewCode
    {
        //static = om het global te maken in de hele class
        static bool QA1;    //for the read question loop
        //static bool QA2;    //for the ask question loop
        static bool QA3;    //for the like loop
        static bool QA4;    //for the name input loop
        static bool QA5;    //for the review input loop
        static string readQA;
        static string nameIn;
        static string reviewIn;

        static Dictionary<string, string> reviewsDict = new Dictionary<string, string>(){
            {"John", "Very nice place!"},
            {"Marie", "Loved the people and the food. Staff was very friendly." },
            {"Paul", "This was a lovely experience."} }; 
        static int likes = 30;

        //---------------------WRITTEN REVIEW MENU------------------------
        public static void AskRev()
        {

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

            QA1 = true;
            //for the question loop below
            while (QA1)
            {
                Console.WriteLine("-- Written Reviews --");
                Console.WriteLine("[R] - Read reviews");
                Console.WriteLine("[W] - Write a review");
                Console.WriteLine("[E] - Go back to main menu of reviews");
                Console.Write("\n: ");
                readQA = Console.ReadLine();
                if (readQA.Equals("r", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Clear();
                    QA1 = false;
                    ReadRevs();
                } else if (readQA.Equals("w", StringComparison.OrdinalIgnoreCase)) {
                    Console.Clear();
                    WriteRevs();
                }
                else if (readQA.Equals("e", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Clear();
                    ColoredConsoleWriteLine(ConsoleColor.Cyan, "Welcome to the Reviews System");
                    Console.WriteLine("[W] - Written reviews \n[S] - Star reviews\n[L] - Number of likes\n[E] - Exit and back to the main page\n");
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
            //QA2 = true;
            //for the question loop below
            Console.Clear();
            Console.WriteLine("~~ Written reviews ~~");
            Console.WriteLine("Total number of reviews: {0}", reviewsDict.Count);

            foreach (KeyValuePair<string, string> i in reviewsDict)
            {
                Console.WriteLine("Name: {0} \n Review: {1} \n",
                    i.Key, i.Value);
            }
            AskRev();
            //print all items in the reviews dictionary

            //while (QA2)
            //{
            //    Console.WriteLine("Do you want to write a review? [Yes] / [No]");
            //    readQA = Console.ReadLine();
            //    if (readQA.Equals("yes", StringComparison.OrdinalIgnoreCase))
            //    {
            //        Console.Clear();
            //        QA2 = false;
            //        WriteRevs();
            //    }
            //    else if (readQA.Equals("no", StringComparison.OrdinalIgnoreCase))
            //    {
            //        Console.Clear();
            //        Console.WriteLine("You chose no, so you will be guided back to the first question of the written reviews page.");
            //        QA2 = false;
            //        AskRev();
            //    }
            //    else
            //    {
            //        Console.WriteLine("Not a valid input, please try again.");
            //    }

            //}
        }

        //---------------------WRITE REVIEWS------------------------
        public static void WriteRevs()
        {
            Console.WriteLine("~~ Write an review ~~");
            QA4 = true;
            QA5 = true;

            while (QA4){
                Console.Write("Write your name here: ");
                nameIn = Console.ReadLine();
                if (string.IsNullOrEmpty(nameIn)) {
                    Console.WriteLine("Empty input, please try again.");
                }
                else
                {
                    QA4 = false;
                }
            }
            while (QA5)
            {
                Console.Write("Write your review here: ");
                reviewIn = Console.ReadLine();
                if (string.IsNullOrEmpty(reviewIn))
                {
                    Console.WriteLine("Empty input, please try again.");
                }
                else
                {
                    QA5 = false;
                }
            }
            Console.Clear();
            Console.WriteLine("\nYour review:\nName: " + nameIn + "\nReview: " + reviewIn);
            reviewsDict.Add(nameIn, reviewIn);
            Console.WriteLine("\nThank you for your review! You will now be guided back to the first question of the written reviews page.");
            AskRev();
        }


        //---------------------LIKES------------------------
        public static void LikeRevs()
        {

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
                    System.Threading.Thread.Sleep(3000);
                    Console.Clear();
                    ColoredConsoleWriteLine(ConsoleColor.Blue, "Welcome to the Reviews System");
                    Console.WriteLine("[W] - Written reviews \n[S] - Star reviews\n[L] - Number of likes\n[E] - Exit and back to the main page\n");
                    QA3 = false;
                }
                else if (readQA.Equals("no", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Clear();
                    ColoredConsoleWriteLine(ConsoleColor.Blue, "Welcome to the Reviews System");
                    Console.WriteLine("[W] - Written reviews \n[S] - Star reviews\n[L] - Number of likes\n[E] - Exit and back to the main page\n");
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


