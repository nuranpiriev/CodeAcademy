namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bird bird1 = new Bird();
            bird1.AgeSetter(9);
            Console.WriteLine(bird1.AgeGetter()); 
           
           
        }
    }
    public class Bird
    {
        public string Name;
        private int _age;
        public Bird()
        {

        }
        public void AgeSetter(int age)
        {
            if (age > 0)
            {
                this._age = age;
                
            }
            else
            {
                Console.WriteLine("Yash 0 dan kicik ola bilmez");
                
            }
           

        }
        public int AgeGetter()
        {
            return _age;
        }

    }
}
