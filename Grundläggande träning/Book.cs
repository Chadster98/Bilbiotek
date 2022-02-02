using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundläggande_träning
{
        public class Book 
    {
        public int Id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public int pages { get; set; }
        public int releaseyear { get; set; }
        

       public Book(int aId, string aTitle, string aAuthor, int aPages, int aReleaseyear)
        {
            Id = aId;
            title = aTitle;
            author = aAuthor;
            pages = aPages;
            releaseyear = aReleaseyear;
        }
            List<Book> books = new List<Book>();
            


        public void VisaBöcker()
        {
            books.Add(new Book(1, "Harry Potter and the Sorcerers Stone", "J.K Rowling", 550, 2003));
            books.Add(new Book(2, "Harry Potter and the Chamber of Secrets", "J.K Rowling", 900, 2004));
            books.Add(new Book(3, "Harry Potter and the Order of the Pheonix", "J.K Rowling", 700, 2005));
            books.Add(new Book(4, "Harry Potter and the Goblet of Fire", "J.K Rowling", 1200, 2009));
            books.Add(new Book(5, "Lord of the rings The Fellowship of the Ring", "Tolkien", 800, 2005));
            books.Add(new Book(6, "Lord of the rings The Two Towers", "Tolkien", 900, 2006));
            books.Add(new Book(7, "Lord of the rings The Return of the King", "Tolkien", 1000, 2007));
            books.Add(new Book(8,"A Game Of Thrones", "George Rr Martin", 590, 2005));
            books.Add(new Book(9, "A Clash of Kings", "George Rr Martin", 800, 2006));
            books.Add(new Book(10, "A Storm of Swords 1: Steel and Snow", "George Rr Martin", 900, 2007));
            
            

            
        }

        public void hanteraBöcker()
        {
            Console.WriteLine();
           

            Console.WriteLine("1. Lämna tillbaka lånad bok.");
            Console.WriteLine("2. Låna en ny bok");
            Console.WriteLine("3. Återvänd till huvudmenyn");

            Console.WriteLine("Knappa in det bestämda valet följt av Enter");
            string input = Console.ReadLine();
            switch (input)
            {
               
                case "1":
                    Console.WriteLine("Skriv in ID tillhörande boken  du lånat.");
                    int idToReturn = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Skriv in titeln på boken");
                    string titleToReturn = Console.ReadLine();
                    Console.WriteLine("Skriv in författaren på boken.");
                    string authorToReturn = Console.ReadLine();
                    Console.WriteLine("Skriv in antal sidor i boken");
                    int pagesToReturn = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Skriv in året boken släpptes.");
                    int releaseYearToReturn = Convert.ToInt32(Console.ReadLine());
                    läggtillNyBok(idToReturn,titleToReturn, authorToReturn, pagesToReturn, releaseYearToReturn);
                    Console.WriteLine("Tack för att ni lämnat tillbaka boken, välkommen åter.");
                    Console.ReadLine();
                    break;
                    
                case "2":
                    foreach (Book i in books)
                    {
                        Console.WriteLine(i.Id + " " + i.title + " " + i.author + " " + i.pages + " " + i.releaseyear);

                    }
                   

                    Console.WriteLine("Skriv in ID tillhörande boken du vill ha.");
                    int itb = Convert.ToInt32(Console.ReadLine());
                    taBortBok(itb);
                    Console.WriteLine("Tack för att ni lånar av oss, ha en trevlig läsning.");
                    Console.ReadLine();
                    break;
                
                case "3":
                    Console.WriteLine("Du återvänder...");
                    Console.ReadLine();
                    break;
                
                default:
                    Console.WriteLine("Något av det du angett stämmer inte. Återvänder till menyn");
                    break;
            }
            void läggtillNyBok(int id, string title, string author, int pages, int releaseyear)
            {
                books.Add(new Book( id, title, author, pages, releaseyear));
               
            }
            void taBortBok(int id)
            {
                books.RemoveAll(x => x.Id == id );
               
            }
           
        }

    }
            

}   

