using System;
using System.IO;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace projectb {
    public class AdminSystem {

        private static string userDatabase = Directory.GetCurrentDirectory() + "/../../../json_files/users.json";

        public static bool adminLoggedin;

        private void GetUserDetails() {
            var json = File.ReadAllText(userDatabase);
            try {
                var jObject = JObject.Parse(json);

                if (jObject != null) {
                    JArray usersArray = (JArray)jObject["users"];
                    if (usersArray != null) {
                        foreach (var item in usersArray) {
                            Console.WriteLine("ID :" + item["userID"].ToString());
                            Console.WriteLine("username :" + item["username"].ToString());
                            Console.WriteLine("password :" + item["password"].ToString());
                        }

                    }
                }
            }
            catch (Exception) {

                throw;
            }
        }

        public static void CheckUserDetails(string user, string pass) {
            var json = File.ReadAllText(userDatabase);
            try {
                var jObject = JObject.Parse(json);

                if (jObject != null) {
                    JArray usersArray = (JArray)jObject["users"];
                    if (usersArray != null) {
                        foreach (var item in usersArray) {
                            if (user == item["username"].ToString()) {
                                if (pass == item["password"].ToString()) {
                                    adminLoggedin = true;
                                } else {
                                    Console.WriteLine("Password is incorrect.");
                                }
                            } else {
                                Console.WriteLine("User does not exist.");
                            }
                        }
                    }
                }
            }
            catch (Exception) {

                throw;
            }
        }

        private void AddUser() {
            Console.WriteLine("Enter Username : ");
            var username = Console.ReadLine();
            Console.WriteLine("\nEnter Password : ");
            var password = Console.ReadLine();

            var newUser = "{ 'username': " + username + ", 'password': '" + password + "'}";  
            try  
            {  
                var json = File.ReadAllText(userDatabase);
                var jsonObj = JObject.Parse(json);
                var usersArray = jsonObj.GetValue("users") as JArray;
                var newAdmin = JObject.Parse(newUser);
                usersArray.Add(newAdmin);  
  
                jsonObj["users"] = usersArray;  
                string newJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj,
                                       Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(userDatabase, newJsonResult);  
            }  
            catch (Exception ex)  
            {  
                Console.WriteLine("Add Error : " + ex.Message.ToString());  
            }  
        }

        private void UpdateUser() {
            string json = File.ReadAllText(userDatabase);

            try {
                var jObject = JObject.Parse(json);
                JArray usersArray = (JArray)jObject["users"];
                Console.Write("Enter username : ");
                var username = Convert.ToString(Console.ReadLine());

                if (!string.IsNullOrEmpty(username)) {
                    Console.Write("Enter new password : ");
                    var password = Convert.ToString(Console.ReadLine());

                    foreach (var user in usersArray.Where(obj => obj["username"].Value<string>() == username)) {
                        user["password"] = !string.IsNullOrEmpty(password) ? password : "";
                    }

                    jObject["users"] = usersArray;
                    string output = Newtonsoft.Json.JsonConvert.SerializeObject(jObject, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(userDatabase, output);
                }
                else {
                    Console.Write("Invalid Company ID, Try Again!");
                    UpdateUser();
                }
            }
            catch (Exception ex) {

                Console.WriteLine("Update Error : " + ex.Message.ToString());
            }
        }

        public AdminSystem() {
       
        }
    }
}
