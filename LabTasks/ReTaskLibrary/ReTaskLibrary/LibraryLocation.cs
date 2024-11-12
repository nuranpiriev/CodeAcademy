using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReTaskLibrary
{
    internal struct LibraryLocation
    {
        public int Aisle {  get; set; }
        public int Shelf {  get; set; }

        public LibraryLocation(int aisle,int shelf)
        {
            Aisle = aisle;
            Shelf = shelf;
            
        }

    }
}
