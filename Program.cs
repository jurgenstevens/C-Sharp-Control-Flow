using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    class ControlFlow
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Max(25, 12, 20));

            Console.ReadLine();
        }
        // call this method a static int since the result will be an integer
        static int Max(int num1, int num2, int num3)
        {
            int result;
            if(num1 >= num2 && num1 >= num3)
            {
                result = num1;
            } else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            } else
            {
                result = num3;
            }

            return result;
        }
    }
}
