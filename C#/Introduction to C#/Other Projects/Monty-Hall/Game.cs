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
        private List<Door>? _doors;
        private Player _player;
        private Host _host;

        public Game(IRandomNumber random) 
        {
            _gameMaster = new GameMaster(random);
            _player = new Player();
            _host = new Host();
        }
        public void PlayGame()
        {
            _doors = _gameMaster.CreateGameDoors();
            _player.pickDoor(_doors);
            _host.hostOpensADoor(_doors);
            _player.switchOrStayDoors(_doors);
        }
        public bool getOutcomeOfGame()
        {
            return _gameMaster.WinOrLose(_doors);
        }
    }
}
