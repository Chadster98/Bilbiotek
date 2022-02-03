using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundläggande_träning
{
    class Program
    {
        static List<Book> books = new List<Book>();
        static List<Person> personer = new List<Person>();
        static Person p1 = new Person("Chadi", "Bader", 199803235895);
        static void Main(string[] args)
        {
            läggTillPersoner();
            läggTillBöcker();
            BiblioteksMeny();
            

        }
        public static void BiblioteksMeny()
        {
            Book books = new Book(0,"", "", 0, 0);
            Person person = new Person("", "", 0);
       
            bool isActive = true;
            while (isActive)
            {
                Console.WriteLine("Välkommen till biblioteket!\n");
                Console.WriteLine("Välj något av nedanstående genom att knappa in respektive siffra.\n");


                List<string> bibliotekMeny = new List<string> { "1. Sök efter en bok", "2. Se tillgängliga böcker", "3. Lämna tillbaka eller låna en ny bok", "4. Se dina lånade böcker", "5. Avsluta" };
                foreach (string i in bibliotekMeny)
                    Console.WriteLine(i);
                int menuSelect = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (menuSelect)
                {
                    case 1:
                        Console.Clear();
                        findBook();
                        break;
                    case 2:
                        Console.Clear();
                        printBooks();
                        break;
                    case 3:
                        Console.Clear();
                        hanteraBöcker();                        
                        break;
                    case 4:
                        Console.Clear();
                        loanedBooksByPerson();
                        break;
                    case 5:
                        isActive = false;
                        break;
                    default:
                        Console.WriteLine("Du har råkat skriva en siffra utanför menyn. Återvänder till menyn.");
                        break;


                }
                
            }
            

                
        }
        //######################TILLÄGGNING AV HÅRDDATA#############################
        static void läggTillBöcker()
        {
            books.Add(new Book(1, "Harry Potter and the Sorcerers Stone", "J.K Rowling", 550, 2003));
            books.Add(new Book(2, "Harry Potter and the Chamber of Secrets", "J.K Rowling", 900, 2004));
            books.Add(new Book(3, "Harry Potter and the Order of the Pheonix", "J.K Rowling", 700, 2005));
            books.Add(new Book(4, "Harry Potter and the Goblet of Fire", "J.K Rowling", 1200, 2009));
            books.Add(new Book(5, "Lord of the rings The Fellowship of the Ring", "Tolkien", 800, 2005));
            books.Add(new Book(6, "Lord of the rings The Two Towers", "Tolkien", 900, 2006));
            books.Add(new Book(7, "Lord of the rings The Return of the King", "Tolkien", 1000, 2007));
            books.Add(new Book(8, "A Game Of Thrones", "George Rr Martin", 590, 2005));
            books.Add(new Book(9, "A Clash of Kings", "George Rr Martin", 800, 2006));
            books.Add(new Book(10, "A Storm of Swords : Steel and Snow", "George Rr Martin", 900, 2007));




        }
        

        static void läggTillPersoner()
        {
            personer.Add(new Person("Chadi", "Bader", 199803235895));

        }


        static void printBooks()
        {
            List<Book> sortedBooks = new List<Book>();
            sortedBooks = books.OrderBy(i => i.Id).ToList();
            foreach (Book i in sortedBooks)
            {
                Console.WriteLine(i.Id + " " + i.title + " " + i.author + " " + i.pages + " " + i.releaseyear);

            }

        }
        static void findBook()
        {
            Console.WriteLine("Vad heter boken du letar efter?");
            string search = Console.ReadLine();
            Console.Clear();
            foreach (Book i in books)
            {
                if (i.title.Contains(search) || i.author.Contains(search) || i.Id == Convert.ToInt32(search))
                {
                    Console.WriteLine(i.Id + " " + i.title + " " + i.author + " " + i.pages + " " + i.releaseyear);
                }
               
            }


            
            /* Läs in vad han vill söka på 
             * Lokalisera böckernas titlar
             * jämföra böckernas titlar med det han sökte
             * Om det han skrivit innehålls i någon av titlarna
             * Skriv ut titlarna
             * 
             * 
             * 
             * 
            */
        }
        

        //#################################ALTERNATIVA MENYER################################
        static void hanteraBöcker()
        {
            Console.WriteLine("1. Lämna tillbaka lånad bok.");
            Console.WriteLine("2. Låna en ny bok");
            Console.WriteLine("3. Återvänd till huvudmenyn");

            Console.WriteLine("Knappa in det bestämda valet följt av Enter");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    lamnaBok();
                    Console.Clear();
                    break;

                case "2":
                    lanaBok();
                    Console.Clear();
                    break;

                case "3":
                    Console.Clear();
                    BiblioteksMeny();
                    break;
                    
            }
        }
        static void lamnaBok()
        {
            Console.WriteLine("Vad är ditt personnummer");
            double personnummer = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Vilken bok vill du lämna tillbaka, ange ID nummer till boken.");
            int bookId = Convert.ToInt32(Console.ReadLine());
            
            
           if(personnummer == p1.IdNumber)
            {
                books.Add(p1.lånadeböcker.Find(Books => Books.Id == bookId));
                p1.lånadeböcker.RemoveAll(Books => Books.Id == bookId);
            }
        }
        static void lanaBok()
        {
            Console.WriteLine("Vad är ditt personnummer");
            double personnummer = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Vilken bok vill du låna?, ange ID nummer till boken.");
            int bookId = Convert.ToInt32(Console.ReadLine());
            p1.lånadeböcker.Add(books.Find(Books => Books.Id == bookId));
            books.RemoveAll(Books => Books.Id == bookId); 

        }
        static void loanedBooksByPerson()
        {
            Console.WriteLine("Välkommen till lånade böcker menyn.\n");
            List<string> lånadeBöcker = new List<string> { "1. Se dina böcker", "2. Återvänd till huvudmenyn" };
            foreach (string i in lånadeBöcker)
                Console.WriteLine(i);

            Console.WriteLine("Knappa in det bestämda valet följt av Enter");
            int inputInfo = Convert.ToInt32(Console.ReadLine());
            switch (inputInfo)
            {                                 
                case 1:
                    Console.Clear();
                    p1.printLoanedBooks();
                    break;
                case 2:
                    Console.Clear();
                    BiblioteksMeny();
                    break;


            }

        }
       


    }



}


            
       
   
            















            

        

    

