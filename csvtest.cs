using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using Newtonsoft.Json;

namespace projectb
{
    //Json file inhoud ------- >>>> item number price <<<<< -----
    public class csvtest
    {
      

        public static void CSVTEST()
        {
   
            string pathstring = "/Users/danine/Documents/School/Programmas/GitHub/QJ7VEG9YggCYmzK5/grades.csv";
            var jsontest = File.ReadAllText(pathstring);

            String[] twee = jsontest.Split(new char[] { '"', ';' }, StringSplitOptions.RemoveEmptyEntries);
         
            foreach (var i in twee)
            {
               Console.Write(i);
            }


        }
    }
}
