using System;
using projectb;

namespace testproject1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool menuRunning = false;
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

            void startProgram() {
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
            }

            Console.WriteLine("Enter '1' if you are a guest.");
            Console.WriteLine("Enter '2' if you are an admin.");
            var startupPath = Convert.ToInt32(Console.ReadLine());

            if (startupPath == 1) {
                menuRunning = true;
                startProgram();
            } else if (startupPath == 2) {
                Console.WriteLine("Username: ");
                string currentUser = Console.ReadLine();
                Console.WriteLine("Password: ");
                string currentPass = Console.ReadLine();
                AdminSystem.CheckUserDetails(currentUser, currentPass);
                if (AdminSystem.adminLoggedin == true) {
                    menuRunning = true;
                    startProgram();
                }
            } else {
                Console.WriteLine("You did not enter valid option");
            }

            Console.WriteLine("END OF PROGRAM");
        }
    }
}
