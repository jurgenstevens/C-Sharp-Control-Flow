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
            // ARRAYS
            // When creating an array in C#, include the brackets to let it know you're doing so
            // that's right, you also use curly braces as to contain the data
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            Console.WriteLine(luckyNumbers[4]);
            // luckyNumbers[1] = 9;
            // Console.WriteLine(luckyNumbers[1]);

            // when creating a new array, include its data type and how many elements the array can hold
            string[] friends = new string[5];
            friends[0] = "Dzenita";
            friends[1] = "David";
            friends[2] = "Chris";

            Console.ReadLine();
        }
    }
}
