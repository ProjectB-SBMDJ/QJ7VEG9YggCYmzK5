using System;


namespace firstdraftproject
{
    class Program //is gewoon een naam van dit tabje
    {
        static bool ask;

        static void Main(string[] arg)
        {
            Console.WriteLine("-- Welcome to the reviews menu page --");
            ask = true;

            while (ask)
            {
                Console.WriteLine("\n[W] - Written reviews \n[S] - Star reviews\n[L] - Number of likes\n[E] - Exit and back to the main page\nhelp - A little help with this menu\n");
                Console.Write("Choose an option: ");
                string revMenu = Console.ReadLine();

                //to ignore the upper- and lowercase use this code below:
                if (revMenu.Equals("w", StringComparison.OrdinalIgnoreCase))  
                {
                    Console.WriteLine("-- Welcome to the WRITTEN REVIEWS page--");
                    Review_test_drie.AskRev();
                    Console.WriteLine("You exited the written reviews page.");
                }
                else if (revMenu.Equals("s", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("-- Welcome to the STAR REVIEWS page--");

                }
                else if (revMenu.Equals("l", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("-- NUMBER OF LIKES --");

                }
                else if (revMenu.Equals("e", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("You exited the review menu");
                    ask = false;
                    //MAIN MENUUU HIEROOO
                }
                else if (revMenu.Equals("help", StringComparison.OrdinalIgnoreCase)){

                    Console.WriteLine("Input the character(s) in the brackets.\n Example: if displayed [yes] then you need to enter yes. Uppercase or lowercase does not matter ");

                }
                else
                {
                    Console.WriteLine("Not a valid input, please try again............");
                }

            }



           
        }
    }
}
