using System;
using System.Collections.Generic;

namespace DaVinci {
    class Program {
        static void Main(string[] args) {

            //VARIABLES
            string reservationName;
            string reservationTime;
            string reservationAmount;
            IList<string> reservations = new List<string>();

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

            void makeReservation() {
                string name = getName();
                string time = getTime();
                string amount = getAmount();
                string reservation = "Reservation for " + amount + " people at " + time + " under the name: " + name;
                reservations.Add(reservation);
            }

            void viewReservation() {
                foreach (var el in reservations)
                    Console.WriteLine(el);
			}

            makeReservation();
            viewReservation();
        }
    }
}