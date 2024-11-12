using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicTask
{
    internal interface IStudentService
    {
        Student GetStudentByID(int id);
        Student[] GetStudentByName(string name);
        Student[] GetAllStudents();
        public void AddStudent(Student student)
        {

        }
        public void UpdateStudent(int id)
        {

        }
        public void RemoveStudent(int id,bool isSoftDelete)
        {

        }
       
    }
}
