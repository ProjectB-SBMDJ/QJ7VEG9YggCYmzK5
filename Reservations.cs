using System;
using System.IO;
using System.Linq;
using Newtonsoft.Json.Linq;
using projectb;

namespace testproject1 {
    public class Reservations {

        private static string reservationsDatabase = Directory.GetCurrentDirectory() + "/../../../json_files/reservations.json";

        public static void ReservationSystem() {

//----------VARIABLES-----------------------------------------------------------------------------------------------
            string reservationName;
            string reservationDate;
            string reservationTime;
            string reservationAmount;
            string menuSelection;
            string resInput;
            bool menuRunning = true;

            Random random = new Random();

//----------FUNCTIONS-----------------------------------------------------------------------------------------------

            //Get name for reservation.
            string getName() {
                Console.Write("Please enter a name for the reservation ([C] to cancel): ");
                reservationName = Console.ReadLine();
                resInput = reservationName;                        
                while (string.IsNullOrEmpty(reservationName)) {
                    Console.WriteLine("Empty input, Please try again");
                    reservationName = Console.ReadLine();
                }
                Console.Clear();
                return reservationName;
            }

            //Get date of reservation
            string getDate() {
                if (resInput != "c") {
                    Console.Write("Please enter the date of this reservation (DD-MM-YYYY): ");
                    reservationDate = Console.ReadLine();
                    while (string.IsNullOrEmpty(reservationDate)) {
                        Console.Write("Empty input, please try again: ");
                        reservationDate = Console.ReadLine();
                    }
                } else {
                    reservationDate = "_";
                }
                Console.Clear();
                return reservationDate;
            }

            //Get time for reservation.
            string getTime() {
                if (resInput != "c") {
                    Console.Write("Please enter the time of the reservation (ex: 18:00): ");
                    reservationTime = Console.ReadLine();
                    while (string.IsNullOrEmpty(reservationTime)) {
                        Console.Write("Empty input, please try again: ");
                        reservationTime = Console.ReadLine();
                    }
                } else {
                    reservationTime = "_";
                }
                Console.Clear();
                return reservationTime;
            }

            //Get amount of guests for reservation.
            string getAmount() {
                if (resInput != "c") {
                    Console.Write("For how many people do you want to reserve: ");
                    reservationAmount = Console.ReadLine();
                    while (string.IsNullOrEmpty(reservationAmount)) {
                        Console.Write("Empty input, Please try again: ");
                        reservationAmount = Console.ReadLine();
                    }
                } else {
                    reservationAmount = "_";
                }
                Console.Clear();
                return reservationAmount;
            }

            //Generate a reservation code to link to the reservation.
            int generateCode() {
                return random.Next(1, 1000);
            }

            //Reads inputs for the reservation menu's options.
            void readMenuInput() {
                Console.Write(": ");
                menuSelection = Console.ReadLine();
            }

            //Makes a reservation and saves it to the json file reservations.json
            void makeReservation() {
                var name = getName();
                var date = getDate();
                var time = getTime();
                var amount = getAmount();
                var code = generateCode();

                if (resInput != "c") {
                    var newReservation = "{ 'name': '" + name + "', 'date': '" + date + "', 'time': '" + time + "', 'amount': " + amount + ", 'code': " + code + "}";
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
                    System.Threading.Thread.Sleep(3000);
                    Console.Clear();
                    menuHelp();
                } else {
                    Console.Clear();
                    menuHelp();
                }                
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
                                Console.WriteLine("Code: " + item["code"].ToString() + "    Name: " + item["name"].ToString() + "   Date: " + item["date"].ToString() + "   Time: " + item["time"].ToString() + "   Amount: " + item["amount"].ToString()); ;
                            }
                        }
                    }
                }
                catch (Exception) {

                    throw;
                }
               
                Console.WriteLine("\n[C] - Go Back to Menu");
            }

            //Delete a reservation from the reservations.json file by entering the reservation code.
            void deleteReservation() {
                var json = File.ReadAllText(reservationsDatabase);
                try {
                    var jObject = JObject.Parse(json);
                    JArray reservationsArray = (JArray)jObject["reservations"];
                    Console.WriteLine("---------- ALL RESERVATIONS ----------");
                    if (reservationsArray != null) {
                        foreach (var item in reservationsArray) {
                            Console.WriteLine("Code: " + item["code"].ToString() + "    Name: " + item["name"].ToString() + "   Date: " + item["date"].ToString() + "   Time: " + item["time"].ToString() + "   Amount: " + item["amount"].ToString()); ;
                        }
                    }
                    Console.Write("\nEnter Reservation Code to Delete Reservation ([C] to cancel): ");
                    var readResCode = Console.ReadLine();
                    Console.Clear();

                    if (readResCode != "c") {
                        if (int.TryParse(readResCode, out _)) {
                            var resCode = Convert.ToInt32(readResCode);
                            if (resCode > 0 && json.ToString().Contains(resCode.ToString())) {
                                var name = string.Empty;
                                var resToDeleted = reservationsArray.FirstOrDefault(obj => obj["code"].Value<int>() == resCode);

                                reservationsArray.Remove(resToDeleted);

                                string output = Newtonsoft.Json.JsonConvert.SerializeObject(jObject, Newtonsoft.Json.Formatting.Indented);
                                File.WriteAllText(reservationsDatabase, output);
                                Console.WriteLine("Reservation has been deleted...");
                                System.Threading.Thread.Sleep(1500);
                                Console.Clear();
                                menuHelp();
                            }
                            else {
                                Console.WriteLine("Reservation not found, please try again");
                                deleteReservation();
                            }
                        }
                        else if (readResCode == "c") {
                            Console.Clear();
                            ReservationSystem();

                        }
                        else {
                            Console.Write("Invalid Reservation Code, Try Again!\n");
                            deleteReservation();
                        }
                    } else {
                        menuHelp();
                    }
                    
                }
                catch (Exception) {

                    throw;
                }
            }

            //Update a reservation, you must use the reservation code to select the reservation that you want to change.
            void updateReservation() {
                string json = File.ReadAllText(reservationsDatabase);

                try {
                    var jObject = JObject.Parse(json);
                    JArray reservationsArray = (JArray)jObject["reservations"];
                    Console.WriteLine("---------- ALL RESERVATIONS ----------");
                    if (reservationsArray != null) {
                        foreach (var item in reservationsArray) {
                            Console.WriteLine("Code: " + item["code"].ToString() + "        Name: " + item["name"].ToString());
                        }
                    }
                    Console.Write("\nEnter Reservation Code to update reservation ([C] to cancel): ");
                    var readResCode = Console.ReadLine();
                    Console.Clear();

                    if (readResCode != "c") {
                        if (int.TryParse(readResCode, out _)) {
                            var resCode = Convert.ToInt32(readResCode);
                            if (resCode > 0 && json.ToString().Contains(resCode.ToString())) {
                                Console.WriteLine("---------- ALL RESERVATIONS ----------");
                                if (reservationsArray != null) {
                                    foreach (var item in reservationsArray) {
                                        if (readResCode == item["code"].ToString()) {
                                            Console.WriteLine("Name: " + item["name"].ToString() + "      Date: " + item["date"].ToString() + "       Time: " + item["time"].ToString() + "       Amount: " + item["amount"].ToString());
                                        }
                                    }
                                }
                                Console.Write("\nWhat would you like to change? (name, amount, time, date): ");
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
                                    case "date":
                                        Console.Write("Enter new date for reservation (DD-MM-YYYY): ");
                                        var newDate = Convert.ToString(Console.ReadLine());
                                        foreach (var reservation in reservationsArray.Where(obj => obj["code"].Value<int>() == resCode)) {
                                            reservation["date"] = !string.IsNullOrEmpty(newDate) ? newDate : "";
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
                                System.Threading.Thread.Sleep(1500);
                                Console.Clear();
                                menuHelp();


                                jObject["reservations"] = reservationsArray;
                                string output = Newtonsoft.Json.JsonConvert.SerializeObject(jObject, Newtonsoft.Json.Formatting.Indented);
                                File.WriteAllText(reservationsDatabase, output);
                            }
                            else {
                                Console.Write("Reservation not found, please try again");
                                updateReservation();
                            }
                        }
                        else {
                            Console.Write("Invalid Reservation Code, Try Again!\n");
                            updateReservation();
                        }
                    } else {
                        menuHelp();
                    }                 
                }
                catch (Exception ex) {

                    Console.WriteLine("Update Error : " + ex.Message.ToString());
                }
            }
        

            //Prints out the options for the reservation menu. If admin is logged in print full menu options.
            //else print guest menu options.
            void menuHelp() {
                Console.WriteLine("----Welcome to the Reservation System----");
                if (AdminSystem.adminLoggedin == true) {
                    Console.WriteLine(" [M] - Make Reservation\n [V] - View Reservations\n [U] - Update/Change Reservations\n [D] - Delete Reservations\n [E] - Exit and back to the main page\n");
                }
                else {
                    Console.WriteLine(" [M] - Make Reservation\n [E] - Exit and back to the main page\n");
                }
            }

            //Reservation Menus for admin and guest.
            menuHelp();
            while (menuRunning) {
                readMenuInput();
                if (AdminSystem.adminLoggedin == true) {
                    switch (menuSelection.ToLower()) {
                        case "c":
                            Console.Clear();
                            menuHelp();
                            break;
                        case "help":
                            Console.Clear();
                            menuHelp();
                            break;
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