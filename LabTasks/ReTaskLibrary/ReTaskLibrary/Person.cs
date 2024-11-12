using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReTaskLibrary
{
    internal abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        protected Person(string name, int id)
        {
          Name = name;
            Id = id;
        }
    }
}
