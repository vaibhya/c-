using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToGameDll
{
	public class Board
	{
		private List<Cell> _boardList = new List<Cell>();
		
		private int _boardSize;
		public Board(int size)
		{
			_boardSize = size;
			for (int i = 0; i < size * size; i++)
			{
				_boardList.Add(new Cell());
			}
		}

		public void MarkCell(int position, Mark mark)
		{

			_boardList[position].SetMark(mark);
		}

		public Boolean IsBoardFull()
		{
			foreach(Cell cell in _boardList)
			{
				if (cell.GetMark == Mark.EMPTY)
				{
					return false;
				}
			}
			return true;
		}
		public Mark GetMarkValue(int index)
		{
			return _boardList[index].GetMark;
		}

		public List<Cell> GetBoardList
		{
			get { return _boardList; }
		}
		public int GetBoardSize
		{
			get { return _boardSize; }
		}
		
	}
}
