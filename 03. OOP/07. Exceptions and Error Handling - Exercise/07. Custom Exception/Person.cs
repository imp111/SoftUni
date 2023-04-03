using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._Custom_Exception
{
    internal class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value", "The first name cannot be null or empty string");
                }

                bool isDigitPresent = value.Any(c => char.IsDigit(c));
                if (isDigitPresent)
                {
                    throw new InvalidPersonNameException("First name cannot contain numbers");
                }

                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value", "The first name cannot be null or empty string");
                }

                bool isDigitPresent = value.Any(c => char.IsDigit(c));
                if (isDigitPresent)
                {
                    throw new InvalidPersonNameException("Last name cannot contain numbers");
                }

                firstName = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0 || value > 120)
                {
                    throw new ArgumentOutOfRangeException("value", "Age should be in the range [0...120]");
                }
                
                age = value;
            }
        }

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
    }
}
