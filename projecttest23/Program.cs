using System;

namespace testproject1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to restaurant app...!");

            
            Console.WriteLine("vul \'review\' in voor review pagina:"); //**zelfde als print() uit python
            string reviewIn = Console.ReadLine();                   //**zo vraag je om input
            if (reviewIn.Equals("review", StringComparison.OrdinalIgnoreCase)) //**negeer hoofdlettergebruik
            {   
                Console.WriteLine("Review gedeelte hieronder:");
                ReviewMenu.MenuRev();
                //**tabje naam + class naam die je aanroept uit dat tabje
            }
            else if (string.IsNullOrEmpty(reviewIn))
            {   //EMPTY INPUT
                Console.WriteLine("Not a valid input, please try again.");
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
