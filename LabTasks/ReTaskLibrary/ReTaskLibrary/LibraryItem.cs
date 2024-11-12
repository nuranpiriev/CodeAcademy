using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReTaskLibrary
{
    internal abstract class LibraryItem
    {
        public int ID {  get; set; }
        public string Title {  get; set; }
        public int? PublicationYear {  get; set; }
        protected LibraryItem(string title,int? publicationYear)
        {
            Title = title;
            PublicationYear = publicationYear;
        }
        public abstract void DisplayInfo();
        
    }
}
