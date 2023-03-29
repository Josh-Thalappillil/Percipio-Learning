using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Monty_Hall
{
    public class RandomNumber : IRandomNumber
    {
        private readonly System.Random _random = new System.Random();

        public int GetNumberBetweenRange(int start, int end)
        {
            return _random.Next(start, end);
        }

        public int getRandomDoorNumber()
        {
            return _random.Next(3);
        }

    }
}
