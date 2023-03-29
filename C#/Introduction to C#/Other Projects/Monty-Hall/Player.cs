using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Monty_Hall
{
    public class Player
    {
        private RandomNumber _random;

        public Player()
        {
            _random = new RandomNumber();
        }

        public void pickDoor(List<Door> doors)
        {
            var doorToBePicked = doors[_random.getRandomDoorNumber()];
            doorToBePicked.opened = true;
            doorToBePicked.picked = true;

        }

        public void switchOrStayDoors(List<Door> doors)
        {

        }
    }
    
}
