using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicTask
{
    internal class StudentService : IStudentService
    {
        private readonly Student[] _students;
        public StudentService(Student[] students)
        {
            _students = students;
        }
        public Student[] GetAllStudents()
        {
            throw new NotImplementedException();
        }

        public Student GetStudentByID(int id)
        {
            for(int i = 0; i < _students.Length; i++)
            {
                if (_students[i].ID == id)
                {
                    return _students[i];
                }

            }
            return default;
        }

        public Student[] GetStudentByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
