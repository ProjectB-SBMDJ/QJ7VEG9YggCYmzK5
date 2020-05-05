using System;
using projectb;

namespace testproject1
{
    class Program
    {
        static bool number = true;
        static string beforeStart;
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
                            Console.Clear();
                            menuHelp();
                            break;
                        case "menu":
                            Console.Clear();
                            Menu.menu();
                            break;
                        case "reviews":
                            Console.Clear();
                            ReviewMenu.MenuRev();
                            break;
                        case "reservations":
                            Console.Clear();
                            Reservations.ReservationSystem();
                            break;
                        case "exit":
                            Console.Clear();
                            menuRunning = false;
                            break;
                        default:
                            Console.WriteLine("Not a valid input, please try again.");
                            break;
                    }
                }
            }

            
           
            number = true;
            //for the loop below
            while (number)
            {
                Console.Write("Enter '1' if you are a guest,");
                Console.Write(" Enter '2' if you are an employee: ");
                beforeStart = Console.ReadLine();
                if (beforeStart.Equals("1", StringComparison.OrdinalIgnoreCase))
                {
                    number = false;
                    
                }
                else if (beforeStart.Equals("2", StringComparison.OrdinalIgnoreCase))
                {
                    number = false;
                }
                else
                {
                    Console.WriteLine("Not a valid input, please try again.");
                }
            }

            var startupPath = Convert.ToInt32(beforeStart);
            Console.Clear();

            if (startupPath == 1) {
                menuRunning = true;
                startProgram();
            } else if (startupPath == 2) {
                Console.Write("Username: ");
                string currentUser = Console.ReadLine();
                Console.Write("Password: ");
                string currentPass = Console.ReadLine();
                AdminSystem.CheckUserDetails(currentUser, currentPass);
                if (AdminSystem.adminLoggedin == true) {
                    menuRunning = true;
                    Console.Clear();
                    startProgram();
                }
            } else {
                Console.WriteLine("You did not enter valid option");
            }

            Console.WriteLine("END OF PROGRAM");
        }
    }
}
