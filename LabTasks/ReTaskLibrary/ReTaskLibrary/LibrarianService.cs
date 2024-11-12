using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReTaskLibrary
{
    internal class LibrarianService : ILibrarianService
    {
        public Librarian[] lib = new Librarian[50]; 
        public int count = 0;   

        public Librarian GetLibrarianByID(int id)
        {
            for (int i = 0;i<count;i++)
            {
                if (lib[i].Id == id)
                {
                    return lib[i];
                }
            }
            return null;
        }
        public Librarian GetAllLibrarians()
        {
            Librarian[] result = new Librarian[count];
            int index = 0;
            foreach (var librarian in lib)
            {
                result[index] = librarian;
                index++;
            }
            return result[index];
        }
        public void CreateLibrarian(Librarian librarian)
        {
            if(count < lib.Length)
            {
                lib[count] = librarian;
                count++;
            }
        }
        public void DeleteLibrarian(Librarian librarian, bool isSoftDelete)
        {
            if(isSoftDelete)
            {
                for(int i = 0; i<count;i++)
                {
                    if (lib[i] == librarian)
                    {
                        for(int j = 0; j < count-1; j++)
                        {
                            lib[j] = lib[j + 1];
                        }
                        count--;
                        break;
                    }
                }
            }

        }
    }
}
