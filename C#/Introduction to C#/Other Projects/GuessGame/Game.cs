using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessGame
{
    public class Game
    {
        private GameEvents _gameEvents;
        private int _userGuess;
        private int _userInputCount;
        public Game()
        {
            _gameEvents = new GameEvents();
        }
        public void PlayGame()
        {
            ConsoleMsg.WelcomeMsg();
            _gameEvents.NumGenerator();
            

            while (true)
            {
                _userGuess = _gameEvents.getUserAnswer();
                _userInputCount = _gameEvents.getInputCount();

                if (_userGuess == _gameEvents.RandomNum) 
                {
                    ConsoleMsg.WinningMsg();
                    break;
                }
                else if (_userGuess < _gameEvents.RandomNum)
                {
                    ConsoleMsg.TooLow();
                    continue;
                }
                else if (_userGuess > _gameEvents.RandomNum)
                {
                    ConsoleMsg.TooHigh();
                    continue;
                }
            }
            ConsoleMsg.GoodbyeMsg(_userInputCount);
        }

    }
}
