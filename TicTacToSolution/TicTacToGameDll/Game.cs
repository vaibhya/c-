using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToGameDll
{
    public class Game
    {
		private Player _player1;
		private Player _player2;
		private Board _board;
		private ResultAnalyzer _resultAnalyzer;
		private Boolean _player1Playing = true;

		public Game(ResultAnalyzer resultAnalyzer, Player player1, Player player2, Board board)
		{
			_resultAnalyzer = resultAnalyzer;
			_player1 = player1;
			_player2 = player2;
			_board = board;
		}
		public void Play(int index)
		{
			_board.MarkCell(index, GetCurrentPlayer().GetMark);
		}
		public Player GetCurrentPlayer()
		{
			if (_player1Playing)
			{
				return _player1;
			}
			return _player2;
		}
		public void SwitchPlayer()
		{
			if (_player1Playing)
			{
				_player1Playing = false;
				return;
			}
			_player1Playing = true;
		}
		public String GetWinner()
		{
			if (_resultAnalyzer.GetWinnerMark == Mark.X)
			{
				return _player1.PlayerName;
			}
			return _player2.PlayerName;

		}
		public Board GetBoard
        {
            get { return _board; }
        }
		public ResultAnalyzer GetResultAnalyzer
        {
            get { return _resultAnalyzer; }
        }
	}
}
