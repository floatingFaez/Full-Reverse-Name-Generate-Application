using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullNameGenerateOOPWorkthoeugh
{
    class Person
    {
        private string firstName;
        private string middleName;
        private string lastName;
        public string FirstName {
            set { firstName = value; }
            get { return firstName; }
        }
        public string MiddleName
        {
            set { middleName = value; }
            get { return middleName; }
        }
        public string LastName
        {
            set { lastName = value; }
            get { return lastName; }
        }
        public string GetFullName() 
        {
            return firstName + " " + middleName + " "+ lastName;
        }
        public string GetFullReverseName()
        {
            string fullName = GetFullName();
            string reverseName = "";

            for (int index = fullName.Length - 1; index >= 0; index--)
            {
                reverseName += fullName[index];
            }
            return reverseName;

        }
    }
}
