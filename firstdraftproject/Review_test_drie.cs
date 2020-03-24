using System;
using System.Collections.Generic;

namespace firstdraftproject
{
    public class Review_test_drie
    {
        //static = om het global te maken in de hele class Review_test_drie
        static bool QA1;    //for the read question loop
        static bool QA2;    //for the ask question loop
        static Dictionary<string, string> reviewsDict = new Dictionary<string, string>(){
            {"John", "Very nice place!"},
            {"Marie", "Loved the people and the food. Staff was very friendly." },
            {"Paul", "This was a lovely experience."}
        };

    //---------------------ASK------------------------
        public static void AskRev(){
            QA1 = true;
            //for the question loop below
            while (QA1)
            {
                Console.WriteLine("Do you want to READ the reviews? [Yes] / [No]");
                string readQA = Console.ReadLine();
                if (readQA.Equals("yes", StringComparison.OrdinalIgnoreCase)){
                    Console.WriteLine("----READ reviews----");
                    QA1 = false;
                    ReadRevs();
                }
                else if (readQA.Equals("no", StringComparison.OrdinalIgnoreCase)){
                    Console.WriteLine("You chose NO, so you will go back to the main page.");
                    QA1 = false;
                }
                else {
                    Console.WriteLine("Not a valid input, please try again.");
                }
            }
            
        }

    //---------------------READ------------------------
        public static void ReadRevs(){
            QA2 = true;
            //for the question loop below
            Console.WriteLine("Total number of reviews: {0}", reviewsDict.Count);

            foreach (KeyValuePair<string, string> i in reviewsDict)
            {
                Console.WriteLine("Name: {0} \n Review: {1} \n",
                    i.Key, i.Value);
            }
            //print alle dingen uit die lijst

            while (QA2)
            {
                Console.WriteLine("Do you want to WRITE a review? [Yes] / [No]");
                string readQA = Console.ReadLine();
                if (readQA.Equals("yes", StringComparison.OrdinalIgnoreCase)){
                    Console.WriteLine("----WRITE review----");
                    QA2 = false;
                    WriteRevs();
                }
                else if (readQA.Equals("no", StringComparison.OrdinalIgnoreCase)){
                    Console.WriteLine("You chose NO, so you will be guided back to the first question");
                    QA2 = false;
                    AskRev();
                }
                else{
                    Console.WriteLine("Not a valid input, please try again.");
                }

            }
        }

    //---------------------WRITE------------------------
        public static void WriteRevs(){
            Console.Write("Write your name here: ");
            string nameIn = Console.ReadLine();
            Console.Write("Write your review here: ");
            string reviewIn = Console.ReadLine();
            Console.WriteLine("\nYour review:\nName: " + nameIn +  "\nReview: " + reviewIn);

            reviewsDict.Add(nameIn, reviewIn);

            Console.WriteLine("\nThank you for your review! You will now be guided back to the first question:");
            AskRev();
        }
    }
}