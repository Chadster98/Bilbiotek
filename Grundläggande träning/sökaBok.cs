using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundläggande_träning
{
    public class sökaBok : Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public int Releaseyear { get; set; }


        public sökaBok(int aId, string aTitle, string aAuthor, int aPages, int aReleaseyear)
        {
            Id = aId;
            Title = aTitle;
            Author = aAuthor;
            Pages = aPages;
            Releaseyear = aReleaseyear;



        }

    }
}
