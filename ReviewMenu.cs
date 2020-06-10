using System;


namespace testproject1 {
    public class ReviewMenu {
        public static void MenuRev() {

            string menuSelection;
            bool menuRunning = true;

            void readMenuInput() {
                menuSelection = Console.ReadLine();
            }

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

            void menuHelp() {
                ColoredConsoleWriteLine(ConsoleColor.Cyan, "Welcome to the Reviews System");
                Console.WriteLine("[W] - Written reviews \n[S] - Star reviews\n[L] - Number of likes\n[E] - Exit and back to the main page\n");
            }

            menuHelp();
            while (menuRunning) {
                Console.Write(": ");
                readMenuInput();
                switch (menuSelection.ToLower()) {
                    case "w":
                        Console.Clear();
                        ReviewCode.AskRev();
                        Console.WriteLine("\nWhat would you like to do now? (enter \'help\' to see options)");
                        break;
                    case "s":
                        StarReviews.StarRevMenu();
                        Console.WriteLine("\nWhat would you like to do now? (enter \'help\' to see options)");
                        break;
                    case "l":
                        ReviewCode.LikeRevs();
                        Console.WriteLine("\nWhat would you like to do now? (enter \'help\' to see options)");
                        break;
                    case "help":
                        menuHelp();
                        break;
                    case "e":
                        Console.Clear();
                        ColoredConsoleWriteLine(ConsoleColor.Red, "Welcome to Restaurant DaVinci!");
                        Console.WriteLine(
                             "[1] - Reviews" +
                             "\n[2] - Reservations" +
                             "\n[3] - Our Menu" +
                             "\n[E] - Close Application"
                        );
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



