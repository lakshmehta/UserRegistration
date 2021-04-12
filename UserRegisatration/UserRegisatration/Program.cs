using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegisatration
{
    class Program
    {
        static void Main(string[] args)
        {
            Pattern patter = new Pattern();
            Console.WriteLine("Enter First_Name:");
            string firstName = Console.ReadLine();
            Console.WriteLine(patter.isValidFirstName(firstName));
            Console.WriteLine("Enter Last_Name:");
            string lastName = Console.ReadLine();
            Console.WriteLine(patter.isValidFirstName(lastName));
            Console.WriteLine("Enter Email_Id");
            string email = Console.ReadLine();
            Console.WriteLine(patter.isValidFirstName(email));

        }
    }
}
