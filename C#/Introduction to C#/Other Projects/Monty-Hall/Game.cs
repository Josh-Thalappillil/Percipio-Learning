using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monty_Hall
{
    public class Game
    {
        private GameMaster _gameMaster;

        public Game(IRandomNumber random) 
        {
            _gameMaster = new GameMaster(random);
        }
        public void PlayGame()
        {
            var doors = _gameMaster.CreateGameDoors();
            Console.WriteLine("Hello");
        }
    }
}
