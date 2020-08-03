using System;
using System.Collections.Generic;
using System.Text;

#nullable disable warnings
namespace NullDemo
{
    public class Person
    {
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }

        public Person(string first, string last)
        {
            FirstName = first;
            MiddleName = null;
            LastName = last;
        }

        public Person(string first, string middle, string last)
        {
            FirstName = first;
            MiddleName = middle;
            LastName = last;
        }
    }
}
