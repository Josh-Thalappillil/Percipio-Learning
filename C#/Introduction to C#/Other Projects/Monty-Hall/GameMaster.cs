using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Monty_Hall
{
    public class GameMaster
    {
        private IRandomNumber _random;

        public GameMaster(IRandomNumber random) 
        {
            _random = random;
        }
        public List<Door> CreateGameDoors()
        {
            var doors = Enumerable.Range(1, 3).Select(Range => new Door { }).ToList();
            doors[_random.GetNumberBetweenRange(0, doors.Count - 1)].injectCarToDoor();
            return doors;

        }

        public void gameEnding(List<Door> doors)
        {
            if (WinOrLose(doors) == true)
            {
                Console.WriteLine("You have won a Car!");
            }
            else
            {
                Console.WriteLine("You lose.");
            }
        }

        public bool WinOrLose(List<Door> doors)
        {
            return doors.First(door => door.picked).hasCar();
                        
        }
    }
}
