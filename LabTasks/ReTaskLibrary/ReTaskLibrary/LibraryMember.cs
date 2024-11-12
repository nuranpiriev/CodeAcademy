using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReTaskLibrary
{
    internal sealed class LibraryMember:Person
    {
        public DateTime MembershipDate {  get; set; }
        public LibraryMember(string name,int age,DateTime membershipDate):base(name,age) 
        {
            MembershipDate = membershipDate;
        }
    }
}
