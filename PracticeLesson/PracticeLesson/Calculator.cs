using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLesson
{
    internal class Calculator
    {
        public int num1;
        public int num2;


        public Calculator()
        {

        }
        public Calculator(int a, int b)
        {
            num1 = a;
            num2 = b;
        }

        
        public void Sum(100)
        {
            int sum = 0;
            for (int i = num1; i < num2; i++)
            {
                sum += i;
            }
            Console.WriteLine("Sum of numbers: " + sum);
        }

    }
}
// a-nan b arasinda olan ededlerin cemin. calculatir mentiqi.
// calculator clasindan instance aliriq , alan anda moterizenin icine iki reqem gondererik
//o gelecek assign edecek numlara a ve b-ye,ondan sonra instance aldigim classa, icindeki sum 
// metodunu cagirib ishledek