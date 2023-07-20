using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLesson.Models
{
    internal class Student
    {
        public string fullName;
        public string address;
        public string age;

        public string GetFullData()
        {

            Book book = new Book();
            book.ShowAdevert();

            return $"Fullname: {fullName}, Address: {address}, Age: {age}";
        }
    }
}
