using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullNameGenerateOOPWorkthoeugh
{
    public class EntryPoint
    {
        public static void Main()
        {
            Person aPerson = new Person();
            Console.Write("Enter your first name : ");
            aPerson.firstName = Console.ReadLine();
            Console.Write("Enter your middle name : ");
            aPerson.middleName = Console.ReadLine();
            Console.Write("Enter your last name : ");
            aPerson.lastName = Console.ReadLine();

            Console.WriteLine("\nYour full name is : " + aPerson.GetFullName());
            Console.WriteLine("Your reverse name is : " + aPerson.GetFullReverseName());

            Console.ReadKey();
        }
    }
}
