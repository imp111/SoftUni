using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._Custom_Exception
{
    internal class Student : Person
    {
        private string email;

        public string Email 
        { 
            get
            {
                return email;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(value), "Email cannot be null or empty");
                }

                email = value;
            }
        }
        
        public Student(string firstName, string lastName, int age, string email) : base(firstName, lastName, age)
        {
            this.Email = email;
        }
    }
}
