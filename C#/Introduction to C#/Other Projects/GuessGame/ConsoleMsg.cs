using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessGame
{
    public class ConsoleMsg
    {
        public void WelcomeMsg()
        {
            Console.WriteLine("Welcome to GuessGame. \n\nChoose a number between 1 and 10.");
        }
        public (int, int) NumberChosen()
        {
            int inputCount = 0;
            while (true)
            {
                Console.ReadLine();
                inputCount++;

                int UserInput;
                while (true)
                {
                    if (!int.TryParse(Console.ReadLine(), out UserInput))
                    {
                        Console.WriteLine("Please enter a valid number.");
                        continue;
                    }

                    if (UserInput < 1 || UserInput > 10)
                    {
                        Console.WriteLine("Please enter a number between 1 and 10.");
                        continue;
                    }
                    break;
                }
                Console.WriteLine($"You guessed {UserInput}.");
            return (UserInput, inputCount);
            }
        }
    }
}
