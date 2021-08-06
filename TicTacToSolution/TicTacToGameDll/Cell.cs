using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToGameDll
{
    public class Cell
    {
        private Mark _mark;
        public Cell()
        {
            _mark = Mark.EMPTY;
        }
        public void SetMark(Mark mark)
        {
            if (_mark == Mark.EMPTY)
            {
                _mark = mark;
                return;
            }
            throw new Exception("Cell Already Marked");

        }
        public Mark GetMark
        {
            get { return _mark; }
        }
    }
}
