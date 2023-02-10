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
            // EXCEPTION HANDLING
            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);

                Console.ReadLine();
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message); // 0 -> "Attempted to divide by zero"
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message); // g -> "Input string was not in correct format"
            }
            //finally
            //{
            //    // OPTIONAL FOR WHEN EXCEPTIONS ARE HIT
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message); // g -> "Input string was not in correct format"
            //}

        }

    }
}
