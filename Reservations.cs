using System;
using System.Collections.Generic;

namespace testproject1 {
    public class Reservations {
        public static void ReservationSystem() {

            //VARIABLES
            string reservationName;
            string reservationTime;
            string reservationAmount;
            string menuSelection;

            bool menuRunning = true;

            IList<string> reservations = new List<string>();

            Random random = new Random();

            //FUNTIONS
            string getName() {
                Console.WriteLine("Please enter a name for the reservation ");
                reservationName = Console.ReadLine();
                return reservationName;
			}

            string getTime() {
                Console.WriteLine("Please enter the time of the reservation (ex: 18:00");
                reservationTime = Console.ReadLine();
                return reservationTime;
            }

            string getAmount() {
                Console.WriteLine("For how many people are you reserving? ");
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
                string reservation = "Code: " + code + "    Name: " + name + "  Time: " + time + "  Amount of Guests: " + amount;
                reservations.Add(reservation);
            }

            void viewReservation() {
                foreach (var el in reservations)
                    Console.WriteLine(el);
			}

            void menuHelp() {
                Console.WriteLine("Enter \'make\' to make a new reservation \nEnter \'view\' to view all reservations");
            }

            //Reservation Menu
            Console.WriteLine("----Welcome to the Reservation System----");
            
            while (menuRunning) {
                readMenuInput();
                switch (menuSelection) {
                    case "make":
                        makeReservation();
                        break;
                    case "view":
                        viewReservation();
                        break;
                    case "help":
                        menuHelp();
                        break;
                    case "exit":
                        menuRunning = false;
                        break;
                }
            }
        }
    }
}