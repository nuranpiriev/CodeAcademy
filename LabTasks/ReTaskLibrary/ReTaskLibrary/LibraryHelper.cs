using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReTaskLibrary
{
    internal static class LibraryHelper
    {
        public static int CalculateAge(this LibraryItem item)
        {
            if(item.PublicationYear == null)
            {
                return 0;
            }
            return DateTime.Now.Year - item.PublicationYear.Value;
        }
    }
}
