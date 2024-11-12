namespace ReTaskLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        { 
           var librarianService = new LibrarianService();
            var librarian = new Librarian("Nuran",2,DateTime.Now);
            librarianService.CreateLibrarian(librarian);
            librarianService.GetAllLibrarians();
        }
    }
}
