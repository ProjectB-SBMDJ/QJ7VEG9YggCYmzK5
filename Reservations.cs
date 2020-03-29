using System;
using System.Collections.Generic;

namespace testproject1 {
    public class Reservations {

        static IList<string> reservations = new List<string>();

        public static void ReservationSystem() {

            //VARIABLES
            string reservationName;
            string reservationTime;
            string reservationAmount;
            string menuSelection;

            bool menuRunning = true;

            //IList<string> reservations = new List<string>();

            Random random = new Random();

            //FUNTIONS
            string getName() {
                Console.WriteLine("Please enter a name for the reservation ");
                reservationName = Console.ReadLine();
                return reservationName;
            }

            string getTime() {
                Console.WriteLine("Please enter the time of the reservation (ex: 18:00)");
                reservationTime = Console.ReadLine();
                return reservationTime;
            }

            string getAmount() {
                Console.WriteLine("For how many people do you want to reserve? ");
                reservationAmount = Console.ReadLine();
                return reservationAmount;
            }

            int generateCode() {
                return random.Next(1, 1000);
            }

            void readMenuInput() {
                menuSelection = Console.ReadLine();
            }

            void makeReservation() {
                string name = getName();
                string time = getTime();
                string amount = getAmount();
                int code = generateCode();
                string reservation = "Code: #" + code + "    Name: " + name + "  Time: " + time + "  Amount of Guests: " + amount;
                reservations.Add(reservation);
                Console.WriteLine("...Reservation Saved...");
                Console.WriteLine("What would you like to do now? (enter \'help\' to see options)");
            }

            void viewReservation() {
                Console.WriteLine("---------- ALL RESERVATIONS ----------");
                foreach (var el in reservations)
                    Console.WriteLine(el);
                Console.WriteLine("\nWhat would you like to do now? (enter \'help\' to see options)");
            }

            void deleteReservation() {
                viewReservation();
                Console.WriteLine("Enter the code of the reservation to delete it: ");
                string toDelete = Console.ReadLine();
                for (int el = reservations.Count - 1; el >= 0; el--) {
                    if (reservations[el].ToString().Contains(toDelete)) {
                        reservations.RemoveAt(el);
                        Console.WriteLine("...Reservation Succesfully Deleted...");
                    }
                    Console.WriteLine("\nWhat would you like to do now? (enter \'help\' to see options)");
                }
            }

            void menuHelp() {
                Console.WriteLine("\n----Reservation Menu----");
                Console.WriteLine(" [M] - Make Reservation\n [V] - View Reservations\n [D] - Delete Reservations\n [E] - Exit and back to the main page\n");
            }

            //Reservation Menu
            Console.WriteLine("\n----Welcome to the Reservation System----");
            Console.WriteLine("Enter \'help\' to see the options");

            while (menuRunning) {
                readMenuInput();
                switch (menuSelection.ToLower()) {
                    case "m":
                        makeReservation();
                        break;
                    case "v":
                        viewReservation();
                        break;
                    case "d":
                        deleteReservation();
                        break;
                    case "help":
                        menuHelp();
                        break;
                    case "e":
                        Console.WriteLine("\n----Welcome Back To The Main Menu----");
                        Console.WriteLine("Enter \'help\' to view the options!");
                        menuRunning = false;
                        break;
                    default:
                        Console.WriteLine("Not a valid input, please try again.");
                        break;
                }
            }
            
        }
    }
}