using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLesson.Models
{
    internal class Product
    {
        public int id;
        public string name;
        public decimal price;
        public DateTime CreatedDate;


        public Product()
        {
            Console.WriteLine("Welcome");
        }


        public Product(string text):this(DateTime.Now)
        {
            Console.WriteLine("this is my text: " + text);
        }

        public Product(DateTime data):this(10,15)
        {
            Console.WriteLine("This is my date");
        }

        public Product(int a, int b)
        {
            Console.WriteLine(a+b);
        }

    }
}
