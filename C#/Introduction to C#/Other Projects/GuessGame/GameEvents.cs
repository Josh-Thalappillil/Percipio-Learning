using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessGame
{
    public class GameEvents
    {
        private Random random;
        int RandomNum;
        public GameEvents()
        {
            Random random = new Random();
            RandomNum = random.Next(1, 11);
            
        }
        public int NumGenerator()
        {
            return RandomNum;
        }
        public void CheckAnswer()
        {
            GameEvents gameEvents = new GameEvents();
            ConsoleMsg consolemsg = new ConsoleMsg();

            (int inputCount, int UserInput) = consolemsg.NumberChosen();

            
            while (true)
            {
                inputCount++;

                while (true)
                {
                    if (UserInput == RandomNum)
                    {
                        Console.WriteLine("CONGRATULATIONS YOU WIN!");
                        break;
                    }
                    else if (UserInput < RandomNum)
                    {
                        Console.WriteLine("You guessed too low, try again.");
                        continue;
                    }
                    else if (UserInput > RandomNum) 
                    {
                        Console.WriteLine("You guessed too high, try again.");
                        continue;
                    }
                }
                Console.WriteLine($"You took {inputCount} tries to get the answer!");
            }
        }
    }
}
