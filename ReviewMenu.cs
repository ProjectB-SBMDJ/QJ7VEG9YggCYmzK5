using System;


namespace testproject1 {
    public class ReviewMenu {
        public static void MenuRev() {

            string menuSelection;
            bool menuRunning = true;

            void readMenuInput() {
                menuSelection = Console.ReadLine();
            }

            void menuHelp() {
                Console.WriteLine("\n----Review Menu----");
                Console.WriteLine(" [W] - Written reviews \n [S] - Star reviews\n [L] - Number of likes\n [E] - Exit and back to the main page\n");
            }

            Console.WriteLine("\n----Welcome to the Reviews Page----");
            menuHelp();
            while (menuRunning) {
                readMenuInput();
                switch (menuSelection.ToLower()) {
                    case "w":
                        ReviewCode.AskRev();
                        Console.Clear();
                        menuHelp();
                        break;
                    case "s":
                        StarReviews.StarRevMenu();
                        Console.Clear();
                        menuHelp();
                        break;
                    case "l":
                        ReviewCode.LikeRevs();
                       
                        menuHelp();
                        break;
                    case "e":
                        Console.WriteLine("\n----Welcome Back To The Main Menu----");
                        Console.WriteLine("Enter \'help\' to view all the options!");
                        menuRunning = false;
                        break;
                    case "":        //empty input
                    case null:      // is invalid
                        Console.WriteLine("Empty input, please try again.");
                        break;
                    default:
                        Console.WriteLine("Not a valid input, please try again.");
                        break;
                }
            }
        }
    }
}



