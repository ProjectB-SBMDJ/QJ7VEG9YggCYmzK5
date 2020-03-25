using System;


namespace testproject1
{
    public class ReviewMenu
    {
        static bool ask;
        //static = om het global te maken in de hele class

        public static void MenuRev()
        {
            Console.WriteLine("Welcome to the reviews menu page.");
            ask = true; //for the loop below
          //  Console.WriteLine("\n=== Review menu ===");
          //  Console.WriteLine(" [W] - Written reviews \n [S] - Star reviews\n [L] - Number of likes\n [E] - Exit and back to the main page\nhelp - A little help with this menu\n");

            while (ask)
            {
                
                Console.WriteLine("\n=== Review menu ===");
                Console.WriteLine(" [W] - Written reviews \n [S] - Star reviews\n [L] - Number of likes\n [E] - Exit and back to the main page\nhelp - A little help with this menu\n");
                
                
                Console.Write("Choose an option: ");
                string RevMenuIn = Console.ReadLine();
                

                if (RevMenuIn.Equals("w", StringComparison.OrdinalIgnoreCase))   //to ignore the upper- and lowercase
                {   //WRITTEN REVIEWS
                    Console.WriteLine("--- Welcome to the written reviews (direction) page ---");
                    ReviewCode.AskRev();
                    Console.Write("....press enter to continue....");
                    Console.ReadLine();
                }
                else if (RevMenuIn.Equals("s", StringComparison.OrdinalIgnoreCase))
                {   //STAR REVIEWS
                    Console.WriteLine("-- Welcome to the star reviews (direction) page--");
                    StarReviews.StarRevMenu();
                    Console.Write("....press enter to continue....");
                    Console.ReadLine();
                }
                else if (RevMenuIn.Equals("l", StringComparison.OrdinalIgnoreCase))
                {   //LIKES
                    ReviewCode.LikeRevs();
                    Console.Write("....press enter to continue....");
                    Console.ReadLine();
                }
                else if (RevMenuIn.Equals("e", StringComparison.OrdinalIgnoreCase))
                {   //EXIT
                    Console.WriteLine("<You exited the main reviews menu page.>");
                    ask = false;
                    //MAIN MENUUU
                }
                else if (RevMenuIn.Equals("help", StringComparison.OrdinalIgnoreCase))
                {   //HELP
                    Console.WriteLine("Input the character(s) in the brackets.\n " + "Example: if displayed [yes] then you need to enter yes. " + "Uppercase or lowercase does not matter.");
                    Console.Write("....press enter to continue....");
                    Console.ReadLine();
                }
                else if (string.IsNullOrEmpty(RevMenuIn))
                {   //EMPTY INPUT
                    Console.WriteLine("Not a valid input, please try again.");
                } else
                {   //INVALID INPUT
                    Console.WriteLine("Not a valid input, please try again.");

                }
                
            }




        }
    }
}



