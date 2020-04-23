using System;
using System.IO;
using System.Linq;
using Newtonsoft.Json.Linq;
using projectb;

namespace testproject1 {
    public class Reservations {

        private static string reservationsDatabase = Directory.GetCurrentDirectory() + "/../../../json_files/reservations.json";

        public static void ReservationSystem() {

            //VARIABLES
            string reservationName;
            string reservationTime;
            string reservationAmount;
            string menuSelection;

            bool menuRunning = true;

            Random random = new Random();

            //---------FUNCTIONS-------------

            //Get name for reservation.
            string getName() {
                Console.WriteLine("Please enter a name for the reservation ");
                reservationName = Console.ReadLine();
                while (string.IsNullOrEmpty(reservationName)) {
                    Console.WriteLine("Empty input, Please try again");
                    reservationName = Console.ReadLine();
                }
                return reservationName;
            }

            //Get time for reservation.
            string getTime() {
                Console.WriteLine("Please enter the time of the reservation (ex: 18:00)");
                reservationTime = Console.ReadLine();
                while (string.IsNullOrEmpty(reservationTime)) {
                    Console.WriteLine("Empty input, Please try again");
                    reservationTime = Console.ReadLine();
                }
                return reservationTime;
            }

            //Get amount of guests for reservation.
            string getAmount() {
                Console.WriteLine("For how many people do you want to reserve? ");
                reservationAmount = Console.ReadLine();
                while (string.IsNullOrEmpty(reservationAmount)) {
                    Console.WriteLine("Empty input, Please try again");
                    reservationAmount = Console.ReadLine();
                }
                return reservationAmount;
            }

            //Generate a reservation code to link to the reservation.
            int generateCode() {
                return random.Next(1, 1000);
            }

            //Reads inputs for the reservation menu's options.
            void readMenuInput() {
                menuSelection = Console.ReadLine();
            }

            //Makes a reservation and saves it to the json file reservations.json
            void makeReservation() {
                var name = getName();
                var time = getTime();
                var amount = getAmount();
                var code = generateCode();

                var newReservation = "{ 'name': '" + name + "', 'time': '" + time + "', 'amount': " + amount + ", 'code': " + code + "}";
                try {
                    var json = File.ReadAllText(reservationsDatabase);
                    var jsonObj = JObject.Parse(json);
                    var reservationsArray = jsonObj.GetValue("reservations") as JArray;
                    var makeReservation = JObject.Parse(newReservation);
                    reservationsArray.Add(makeReservation);

                    jsonObj["reservations"] = reservationsArray;
                    string newJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj,
                                           Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(reservationsDatabase, newJsonResult);
                }
                catch (Exception ex) {
                    Console.WriteLine("Add Error : " + ex.Message.ToString());
                }

                Console.Clear();
                Console.WriteLine("Reservation Saved... Your reservation code is: " + code);
                Console.WriteLine("What would you like to do now? (enter \'help\' to see options)");
            }

            //View all of the reservations in the reservations.json file
            void viewReservation() {
                Console.WriteLine("---------- ALL RESERVATIONS ----------");
                var json = File.ReadAllText(reservationsDatabase);
                try {
                    var jObject = JObject.Parse(json);

                    if (jObject != null) {
                        JArray reservationsArray = (JArray)jObject["reservations"];
                        if (reservationsArray != null) {
                            foreach (var item in reservationsArray) {
                                Console.WriteLine("Code: " + item["code"].ToString() + "    Name: " + item["name"].ToString() + "   Time: " + item["time"].ToString() + "   Amount: " + item["amount"].ToString());
                            }
                        }
                    }
                }
                catch (Exception) {

                    throw;
                }
               
                Console.WriteLine("\nWhat would you like to do now? (enter \'help\' to see options)");
            }

            //Delete a reservation from the reservations.json file by entering the reservation code.
            void deleteReservation() {
                var json = File.ReadAllText(reservationsDatabase);
                try {
                    var jObject = JObject.Parse(json);
                    JArray reservationsArray = (JArray)jObject["reservations"];
                    Console.Write("Enter Reservation Code to Delete Reservation ([E] to cancel): ");
                    var readResCode = Console.ReadLine();
                    Console.Clear();

                    if (int.TryParse(readResCode, out _)) {
                        var resCode = Convert.ToInt32(readResCode);
                        if (resCode > 0 && json.ToString().Contains(resCode.ToString())) {
                            var name = string.Empty;
                            var resToDeleted = reservationsArray.FirstOrDefault(obj => obj["code"].Value<int>() == resCode);

                            reservationsArray.Remove(resToDeleted);

                            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jObject, Newtonsoft.Json.Formatting.Indented);
                            File.WriteAllText(reservationsDatabase, output);
                            Console.WriteLine("Reservation has been deleted.");
                            Console.WriteLine("What would you like to do now? (enter \'help\' to see options)");
                        }
                        else {
                            Console.WriteLine("Reservation not found, please try again");
                            deleteReservation();
                        }
                    } else if (readResCode == "e") {
                        Console.Clear();
                        ReservationSystem();

                    } else {
                        Console.Write("Invalid Reservation Code, Try Again!\n");
                        deleteReservation();
                    }
                }
                catch (Exception) {

                    throw;
                }
            }

            void updateReservation() {
                string json = File.ReadAllText(reservationsDatabase);

                try {
                    var jObject = JObject.Parse(json);
                    JArray reservationsArray = (JArray)jObject["reservations"];
                    Console.WriteLine("---------- ALL RESERVATIONS ----------");
                    if (reservationsArray != null) {
                        foreach (var item in reservationsArray) {
                            Console.WriteLine("Code: " + item["code"].ToString() + "        Name: " + item["name"].ToString() + "       Time: " + item["time"].ToString() + "       Amount: " + item["amount"].ToString());
                        }

                    }
                    Console.Write("\nEnter Reservation Code to update reservation ([E] to cancel): ");
                    var readResCode = Console.ReadLine();
                    Console.Clear();

                    if (int.TryParse(readResCode, out _)) {
                        var resCode = Convert.ToInt32(readResCode);
                        if (resCode > 0 && json.ToString().Contains(resCode.ToString())) {
                            Console.Write("What would you like to change? (name, amount, time): ");
                            var toChange = Console.ReadLine();
                            Console.Clear();
                            switch (toChange) {
                                case "name":
                                    Console.Write("Enter new name for reservation: ");
                                    var newName = Convert.ToString(Console.ReadLine());
                                    foreach (var reservation in reservationsArray.Where(obj => obj["code"].Value<int>() == resCode)) {
                                        reservation["name"] = !string.IsNullOrEmpty(newName) ? newName : "";
                                    }
                                    break;
                                case "amount":
                                    Console.Write("Enter new amount of guests for reservation: ");
                                    var newAmount = Convert.ToString(Console.ReadLine());
                                    foreach (var reservation in reservationsArray.Where(obj => obj["code"].Value<int>() == resCode)) {
                                        reservation["amount"] = !string.IsNullOrEmpty(newAmount) ? newAmount : "";
                                    }
                                    break;
                                case "time":
                                    Console.Write("Enter new time for reservation: ");
                                    var newTime = Convert.ToString(Console.ReadLine());
                                    foreach (var reservation in reservationsArray.Where(obj => obj["code"].Value<int>() == resCode)) {
                                        reservation["time"] = !string.IsNullOrEmpty(newTime) ? newTime : "";
                                    }
                                    break;
                            }
                            Console.Clear();
                            Console.WriteLine("Reservation updated...");
                            Console.WriteLine("What would you like to do now? (enter \'help\' to see options)");


                            jObject["reservations"] = reservationsArray;
                            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jObject, Newtonsoft.Json.Formatting.Indented);
                            File.WriteAllText(reservationsDatabase, output);
                        }
                        else {
                            Console.Write("Reservation not found, please try again");
                            updateReservation();
                        }
                    } else if (readResCode == "e"){
                        Console.Clear();
                        ReservationSystem();
                    } else {
                        Console.Write("Invalid Reservation Code, Try Again!\n");
                        updateReservation();
                    }
                }
                catch (Exception ex) {

                    Console.WriteLine("Update Error : " + ex.Message.ToString());
                }
            }
        

            //Prints out the options for the reservation menu. If admin is logged in print full menu options.
            //else print guest menu options.
            void menuHelp() {
                Console.WriteLine("----Reservation Menu----");
                if (AdminSystem.adminLoggedin == true) {
                    Console.WriteLine(" [M] - Make Reservation\n [V] - View Reservations\n [U] - Update/Change Reservations\n [D] - Delete Reservations\n [E] - Exit and back to the main page\n");
                }
                else {
                    Console.WriteLine(" [M] - Make Reservation\n [E] - Exit and back to the main page\n");
                }
            }

            //Reservation Menu
            Console.WriteLine("----Welcome to the Reservation System----");
            Console.WriteLine("Enter \'help\' to see the options");

            while (menuRunning) {
                readMenuInput();
                if (AdminSystem.adminLoggedin == true) {
                    switch (menuSelection.ToLower()) {
                        case "m":
                            Console.Clear();
                            makeReservation();
                            break;
                        case "v":
                            Console.Clear();
                            viewReservation();
                            break;
                        case "d":
                            Console.Clear();
                            deleteReservation();
                            break;
                        case "u":
                            Console.Clear();
                            updateReservation();
                            break;
                        case "help":
                            Console.Clear();
                            menuHelp();
                            break;
                        case "e":
                            Console.Clear();
                            Console.WriteLine("----Welcome Back To The Main Menu----");
                            Console.WriteLine("Enter \'help\' to view the options!");
                            menuRunning = false;
                            break;
                        case null:
                        case "":
                            Console.WriteLine("Empty input, please try again");
                            break;
                        default:
                            Console.WriteLine("Not a valid input, please try again.");
                            break;
                    }
                }
                else { 
                    switch (menuSelection.ToLower()) {
                        case "m":
                            makeReservation();
                            break;
                        case "help":
                            menuHelp();
                            break;
                        case "e":
                            Console.WriteLine("\n----Welcome Back To The Main Menu----");
                            Console.WriteLine("Enter \'help\' to view the options!");
                            menuRunning = false;
                            break;
                        case null:
                        case "":
                            Console.WriteLine("Empty input, please try again");
                            break;
                        default:
                            Console.WriteLine("Not a valid input, please try again.");
                            break;
                    }
                }
            } 
        }
    }
}