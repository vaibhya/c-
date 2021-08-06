using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberGuessingGame
{
    class GameTest
    {
        static void Main(string[] args)
        {
            GameModel game = new GameModel();
            game.GuessNumber();
        }
    }
}
