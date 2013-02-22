using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GOL.Library
{
    public class Grid
    {
        private int length;
        private int breath;

        private Cell[][] cells;

        public Grid() { }

        public Grid(int _length, int _breath)
        {
            this.Length = _length;
            this.Breath = _breath;

            CreateGrid();
        }

  
        public void CreateGrid()
        {
             cells = new Cell[Length][];
            for (int i = 0; i < Length; i++)
            {
                cells[i] = new Cell[Breath];
                for (int j = 0; j < Breath; j++)
                {
                    cells[i][j] = new Cell(i,j,false);
                }
            }
        }

        public Cell this[int _rowNumber, int _colNumber]
        {
            get
            {
                if (_colNumber < 0 || _rowNumber < 0 || _colNumber >= this.Breath || _rowNumber >= this.Length)
                {
                    throw new ArgumentOutOfRangeException("The rowNumber and columnNumber values should be within the dimensions of the Grid.");
                }
                return cells[_rowNumber][_colNumber];
            }
        }

        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }

        public int Breath
        {
            get
            {
                return breath;
            }
            set
            {
                breath = value;
            }
        }


    }
}
