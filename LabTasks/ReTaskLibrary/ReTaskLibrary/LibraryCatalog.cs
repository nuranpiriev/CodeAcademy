using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ReTaskLibrary
{
    internal class LibraryCatalog
    {
        public LibraryItem[] Catalog = new LibraryItem[50];
        public int Count = 0;
        public LibraryItem GetLibraryItemByID(int id)
        {
            for (int i = 0; i < Count; i++)
            {
                if (Catalog[i].ID == id)
                {
                    return Catalog[i];
                }
                
            }
            throw new CustomBookException($"Book with ID {id} is not found in the catalog.");
        }
        public void AddLibraryItem(LibraryItem item)
        {
            if(Count < Catalog.Length)
            {
                Catalog[Count] = item;
                Count++;
            }
        }
    }
}
