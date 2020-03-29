using System;
using testproject1;

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
            // **notes van danine zijn met sterretjes**
            //**Hier keuze menu
            //**Admin kan eigen eigen woord krijgen dat ze moeten invullen dat niet in het menu komt
            //**vb: menu keuzes zijn 'rev', 'menu' & 'help'. als admin dan 'admin' intikt komt tie in zijn eigen pagina
            //**tenzij iemand username + password werkend krijgt..?



            Console.WriteLine("END OF PROGRAM");
        }
    }
}
