using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReTaskLibrary
{
    internal class Book : LibraryItem
    {
        public BookGenre Genre {  get; set; }
        public LibraryLocation Location { get; set; }
        public Book(string title,int? publicationYear,BookGenre genre,LibraryLocation location):base(title,publicationYear)
        {
            Location = location;
            Genre = genre;
            
        }
        public override void DisplayInfo()
        {
            throw new NotImplementedException();
        }
    }
}
