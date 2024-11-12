using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReTaskLibrary
{
    internal interface ILibrarianService
    {
        Librarian GetLibrarianByID(int id);
        Librarian GetAllLibrarians();
        void CreateLibrarian(Librarian librarian);
        void DeleteLibrarian(Librarian librarian, bool isSoftDelete);
    }
}
