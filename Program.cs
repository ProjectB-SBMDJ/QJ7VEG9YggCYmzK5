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
                Console.WriteLine(
                    "[1] - Reviews" +
                    "\n[2] - Reservations" +
                    "\n[3] - Our Menu" +
                    "\n[E] - Close Application"
                );
            }

            void startProgram() {
                ColoredConsoleWriteLine(ConsoleColor.Red, "Welcome to Restaurant DaVinci!");
                menuHelp();
                Console.Write("\n: ");

                while (menuRunning) {
                    readMenuInput();
                    switch (menuSelection.ToLower()) {
                        case "help":
                            Console.Clear();
                            menuHelp();
                            break;
                        case "3":
                            Console.Clear();
                            Menu.menu();
                            break;
                        case "1":
                            Console.Clear();
                            ReviewMenu.MenuRev();
                            break;
                        case "2":
                            Console.Clear();
                            Reservations.ReservationSystem();
                            break;
                        case "e":
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
