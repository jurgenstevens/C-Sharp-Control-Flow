using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ControlFlow
{
    class ControlFlow
    {
        static void Main(string[] args)
        {
            /* Nested
             Arrays
             */
            int[,] NumberGrid =
            {
                { 1, 2 },
                { 3, 4 },
                { 5, 6 }
            };

            Console.WriteLine(NumberGrid[1, 1]);

            Console.ReadLine();
        }

    }
}
