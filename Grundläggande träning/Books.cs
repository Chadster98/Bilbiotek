

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
       
    }
   
}
