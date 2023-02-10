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
            // WHILE LOOPS
            int index = 1;
            WHILE LOOP
            while (index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }
            DO WHILE LOOP
            do
            {
                Console.WriteLine(index);
                index++;
            } while (index <= 5);
            // WHILE LOOP GAME
            string secretWord = "giraffe";
            string guess = "";

            while (guess != secretWord)
            {
                Console.Write("Enter guess: ");
                guess = Console.ReadLine();
            }
            Console.Write("You win!");
            // DO WHILE GAME
            do
            {
                Console.Write("Enter guess: ");
                guess = Console.ReadLine();
            } while (guess != secretWord);
            Console.Write("You win!");

            Console.ReadLine();
        }
    }
}
