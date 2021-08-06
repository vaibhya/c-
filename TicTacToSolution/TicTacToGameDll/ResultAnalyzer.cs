using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToGameDll
{
    public class ResultAnalyzer
    {
		private Board _board;
		private int _boardSize;
		private String _expectedXString = "";
		private String _expectedOString = "";
		private Mark _winnerMark;

		public ResultAnalyzer(Board board)
		{
			_board = board;
			_boardSize = board.GetBoardSize;
			for (int i = 0; i < _boardSize; i++)
			{
				_expectedXString += Mark.X;
				_expectedOString += Mark.O;
			}
		}
		public Boolean FindRowWinner()
		{
			int startRow = 0;
			for (int j = 0; j < _boardSize; j++)
			{
				String checkWinner = "";
				for (int i = 0; i < _boardSize; i++)
				{
					checkWinner += _board.GetMarkValue(startRow++);
				}
				if (checkWinner==_expectedXString)
				{
					_winnerMark = Mark.X;
					return true;
				}
				if (checkWinner==_expectedOString)
				{
					_winnerMark = Mark.O;
					return true;
				}
			}
			return false;
		}

		public Boolean FindColumnWinner()
		{
		
			for (int j = 0; j < _boardSize; j++)
			{
				int startColum = j;
				String checkString = "";
				for (int i = 0; i < _boardSize; i++)
				{
					checkString += _board.GetMarkValue(startColum);
					startColum += _boardSize;
				}
				if (checkString==_expectedXString)
				{
					_winnerMark = Mark.X;
					return true;
				}
				if (checkString==_expectedOString)
				{
					_winnerMark = Mark.O;
					return true;
				}
			}
			return false;
		}
		public Boolean FindDiagonalWinner1()
		{
			int diagonalAssist = 0;
			String checkLine = "";
			for (int i = 0; i < _boardSize; i++)
			{
				checkLine += _board.GetMarkValue(diagonalAssist);
				diagonalAssist += _boardSize + 1;
			}
			if (checkLine==_expectedXString)
			{
				_winnerMark = Mark.X;
				return true;
			}
			if (checkLine==_expectedOString)
			{
				_winnerMark = Mark.O;
				return true;
			}
			return false;
		}
		public Boolean FindDiagonalWinner2()
		{
			int diagonalAssist = _boardSize - 1;
			String checkLine = "";
			for (int i = 0; i < _boardSize; i++)
			{
				checkLine += _board.GetMarkValue(diagonalAssist);
				diagonalAssist += _boardSize - 1;
			}
			if (checkLine==_expectedXString)
			{
				_winnerMark = Mark.X;
				return true;
			}
			if (checkLine==_expectedOString)
			{
				_winnerMark = Mark.O;
				return true;
			}
			return false;
		}
		public Boolean FindWinner()
		{
			if (FindColumnWinner())
			{
				return true;
			}
			else if (FindRowWinner())
			{
				return true;
			}
			else if (FindDiagonalWinner1())
			{
				return true;
			}
			else if (FindDiagonalWinner2())
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public String GetExpectedXString
		{
			get { return _expectedXString; }
		}
		public String GetExpectedOString
		{
            get { return _expectedOString; }
			
		}
		public void SetWinnerMark(Mark mark)
		{
			_winnerMark = mark;
		}
		public Mark GetWinnerMark
		{
            get { return _winnerMark; }
			
		}

	}
}
