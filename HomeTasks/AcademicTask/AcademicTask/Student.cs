using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicTask
{
    internal class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public double GPA { get; set; }
        public StudentE Status { get; set; }
        public StudentB Major { get; set; }

        public Student(int id,string firstName,string lastName,StudentE status, StudentB major)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Status = status;
            Major = major;
            
        }
    }
}
