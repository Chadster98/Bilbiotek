using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundläggande_träning
{
    class Program
    {
        static void Main(string[] args)
        {
            BiblioteksMeny();

        }
        public static void BiblioteksMeny()
        {
            Book books = new Book(0,"", "", 0, 0);
            books.VisaBöcker();
           


            Console.WriteLine("Välkommen till biblioteket!\n");
            Console.WriteLine("Välj något av nedanstående genom att knappa in respektive siffra.\n");
            

            List<string> bibliotekMeny = new List<string> { "1. Sök efter en bok", "2. Se tillgängliga böcker", "3. Lämna tillbaka eller låna en ny bok", "4. Se dina lånade böcker", "5. Avsluta" };
            foreach (string i in bibliotekMeny)
                Console.WriteLine(i);
            int menuSelect = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            while (true)
            {
                switch (menuSelect)
                {
                    case 1:
                        Console.WriteLine();
                        break;
                    case 2:
                        books.VisaBöcker();
                        break;
                    case 3:
                        books.hanteraBöcker();
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine();
                        break;
                    case 5:
                        ExitMenu();
                        break;
                    default:
                        Console.WriteLine("Du har råkat skriva en siffra utanför menyn. Återvänder till menyn.");
                        break;


                }
                
            }
            

                
            }
        public static void ExitMenu()
        {
            Console.WriteLine("Tryck frivillig knapp för att stänga av programmet.");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
    }


            
       
   
            















            

        

    

