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
        public void GoodbyeMsg()
        {
            GameEvents gameEvents = new GameEvents();
            Console.WriteLine($"You took {gameEvents.CheckAnswer} tries to get the answer!");
        }
    }
}
