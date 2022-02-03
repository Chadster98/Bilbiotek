using System;
using System.Collections.Generic;
using System.Linq;


namespace Grundläggande_träning
{
    public class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public double IdNumber { get; }
       public List<Book> lånadeböcker = new List<Book>();

        public Person(string _Firstname, string _Lastname, double _IdNumber)
        {
            Firstname = _Firstname;
            Lastname = _Lastname;
            IdNumber = _IdNumber;

        }

        public double getID()
        {
            return IdNumber;
        }
        public void seePositions()
        {
            if (lånadeböcker.Count == 0)
            {
                Console.WriteLine("Du har inga lånade böcker.");
            }
            else
            {
                foreach (Book item in lånadeböcker)
                {
                    Console.WriteLine(item);
                }
            }


        }
        public void addLoanedBook(int bookId, string title, string author, int pages, int releaseyear)
        {
            lånadeböcker.Add(new Book(bookId, title, author, pages, releaseyear));
        }
        public void removeLoanedBook(int id)
        {
            lånadeböcker.RemoveAll(x => x.Id == id);
        }
       public void printLoanedBooks()
        {
            List<Book> sortedBooks = new List<Book>();
            sortedBooks = lånadeböcker.OrderBy(i => i.Id).ToList();
            foreach (Book i in sortedBooks)
            {
                Console.WriteLine(i.Id + " " + i.title + " " + i.author + " " + i.pages + " " + i.releaseyear);

            }
        }
    }
}
