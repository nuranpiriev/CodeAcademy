using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReTaskLibrary
{
    internal class Librarian : Person
    {
        public DateTime HireDate {  get; set; }
        public Librarian(string name,int id,DateTime hireDate):base(name,id)
        {
             Id = id;
            Name = name;
            HireDate = hireDate;    
        }

    }
}
