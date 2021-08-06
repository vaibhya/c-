using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToGameDll
{
    public class Player
    {
        private Mark _mark;
        private String _playerName;
        public Player(String playerName,Mark mark)
        {
            _mark = mark;
            _playerName = playerName;
        }
        public void SetPlayerName(String playerName)
        {
            _playerName = playerName;   
        }
        public void SetPlayerMark(Mark mark)
        {
            _mark = mark;
        }
        public Mark GetMark
        {
            get { return _mark; }
        }
        public String PlayerName
        {
            get { return _playerName; }
        }
    }
}
