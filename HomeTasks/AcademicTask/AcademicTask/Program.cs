namespace AcademicTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student()
            {
                ID = 1,
                FirstName = "Test",
            };
            Student student2 = new Student()
            {
                ID = 2,
                FirstName = "TEAR",
            };
            Student[] students = { student,student2 };
        }
    }
}
