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
            // IF STATEMENTS
            bool isMale = false;
            bool isTall = true;
            // && works for AND just like in JS
            // || work for OR just like in JS
            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male");
            } else if (isMale && !isTall)
            {
                Console.WriteLine("You're a short male");
            } else if (!isMale && isTall) {
                Console.WriteLine("You are not male but you are tall");
            }
            else
            {
                Console.WriteLine("You are neither tall nor male");
            }

            Console.ReadLine();
        }
    }
}
