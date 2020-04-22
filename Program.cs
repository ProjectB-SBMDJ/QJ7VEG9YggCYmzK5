using System;

namespace testproject1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool menuRunning = true;
            string menuSelection;

            void readMenuInput() {
                menuSelection = Console.ReadLine();
            }

            void menuHelp() {
                Console.WriteLine(
                    "Enter \'reviews\' to view the Reviews Menu! " +
                    "\nEnter \'reservations\' to view the Reservation Menu! " +
                    "\nEnter \'menu\' to view the different Food Menu's! " +
                    "\nEnter \'exit\' to shutdown the application!"
                );
            }

            Console.WriteLine("Welcome to the restaurant's console application");
            Console.WriteLine("Enter \'help\' to view the options!");

            while (menuRunning) {
                readMenuInput();
                switch (menuSelection.ToLower()) {
                    case "help":
                        menuHelp();
                        break;
                    case "menu":
                        Menu.menu();
                        break;
                    case "m":
                        Menu.menu();
                        break;
                    case "reviews":
                        ReviewMenu.MenuRev();
                        break;
                    case "reservations":
                        Reservations.ReservationSystem();
                        break;
                    case "exit":
                        menuRunning = false;
                        break;
                    default:
                        Console.WriteLine("Not a valid input, please try again.");
                        break;
                }   
            }
            Console.WriteLine("END OF PROGRAM");
        }
    }
}
