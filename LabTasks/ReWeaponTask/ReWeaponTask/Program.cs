namespace ReWeaponTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Emin peyser";
            string result = "";

           for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == ' ')
                {
                    result = result + "\n";
                }
                else
                {
                    Console.WriteLine(name[i]);
                }
            }
        }
    }
}
