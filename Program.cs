using System.Text.RegularExpressions;

namespace REG
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string mob = "^[0-9]{10}$";
            string pinc = "^[0-9]{6}$";
            string alpha = "^[A-Za-z]+$";
            //string numbrbetween = "[a-zA-Z]*[0-9][A-Za-z]+";
            string email = "[A-Za-z]*[0-9]*[@][A-Za-z]+[.][a-zA-Z]+";
            string password = "[A-Z]{1}[A-Za-z]*[@][0-9]";
            Regex obj = new Regex(password);
            string s = "Shailendra@123";
            bool r = obj.IsMatch(s);
            Console.WriteLine(r);


            
            Console.WriteLine("Hello, World!");
        }
    }
}