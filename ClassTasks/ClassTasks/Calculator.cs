using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTasks
{
    internal class Calculator
    {

        public void Sum(decimal a, decimal b)
        {
            Console.WriteLine(a + b);
        }

        public void Minus(decimal a, decimal b)
        {
            Console.WriteLine(a - b);
        }


        public void Multiplication(decimal a, decimal b)
        {
            Console.WriteLine(a * b);
        }
        public void Division(decimal a, decimal b)
        {
            Console.WriteLine(a / b);
        }
    }
}
