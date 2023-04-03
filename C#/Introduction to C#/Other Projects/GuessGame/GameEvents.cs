using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessGame
{
    public class GameEvents
    {
        int RandomNum;
        
        public int NumGenerator()
        {
            Random random = new Random();
            RandomNum = random.Next(1, 11);
            return RandomNum;
        }
        
        public void CheckAnswer()
        {
            GameEvents gameEvents = new GameEvents();
            gameEvents.NumGenerator();

            int inputCount = 0;
            int UserInput;

            while (true)
            {
                Console.WriteLine("\nEnter your guess:");
                UserInput = Convert.ToInt32(Console.ReadLine());
                inputCount++;

                                
                if (UserInput == gameEvents.RandomNum)
                {
                    Console.WriteLine("CONGRATULATIONS YOU WIN!");
                    break;
                }
                else if (UserInput < gameEvents.RandomNum)
                {
                    Console.WriteLine("You guessed too low, try again.");
                    continue;
                }
                else if (UserInput > gameEvents.RandomNum) 
                {
                    Console.WriteLine("You guessed too high, try again.");
                    continue;
                }
            }
            Console.WriteLine($"You took {inputCount} tries to get the answer!");
        }
    }
}
