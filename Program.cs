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
            int cubedNumber = cube(5);
            Console.WriteLine(cubedNumber);
            Console.ReadLine();
        }
        // specify the data type you're going to return with the method
        static int cube(int num)
        {
            int result = num * num * num;
            return result;
        }

    }
}
