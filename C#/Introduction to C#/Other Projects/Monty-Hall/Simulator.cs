using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monty_Hall
{
    internal class Simulator
    {
        private RandomNumber _random;

        public Simulator()
        {
            _random = new RandomNumber();
        }
        public void simulate1000()
        {
            var gamesWon = 0;
            var game = new Game(_random);
            
            for (int i = 0; i < 1000; i++) 
            {
                game.PlayGame();
                if (game.getOutcomeOfGame() == true)
                {
                    gamesWon++;
                }
            }
            var lossess = ((1000 - gamesWon) / 1000.0) * 100;
            var gameWon = (gamesWon / 1000.0) * 100;
            Console.WriteLine($"{gameWon}% Games Won. {lossess}% Games Lost.");
            Console.WriteLine($"{gamesWon}");
        }
    }
}
