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

            aPerson.firstName = "Abul";
            aPerson.middleName = "Faez";
            aPerson.lastName = "Sajib";

            Console.WriteLine("Your full name is : " + aPerson.GetFullName());
            Console.WriteLine("Your reverse name is : " + aPerson.GetFullReverseName());

            Console.ReadKey();
        }
    }
}
