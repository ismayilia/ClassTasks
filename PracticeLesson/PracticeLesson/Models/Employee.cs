using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLesson.Models
{
    internal class Employee
    {
        public string fullName;
        public string address;
        public string age;
        public decimal salary;

        public void Test()
        {
            Book book = new Book();
            book.ShowAdevert();
            Console.WriteLine("test");

        }
    }
}
