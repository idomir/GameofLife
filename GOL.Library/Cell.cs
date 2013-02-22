using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GOL.Library
{
    /// <summary>
    /// Entity for maintaining the state for a single cell in a Grid.
    /// It maintains its location on the Grid with its state as either true or false.
    /// </summary>
   public class Cell
    {
        private bool isAlive;
        private int rowNumber;
        private int colNumber;

        public Cell(int _rowNum, int _colNum, bool _isAlive)
        {
            this.isAlive = _isAlive;
            this.rowNumber = _rowNum;
            this.colNumber = _colNum;
        }


        public bool IsAlive {
            get
            {
                return isAlive;
            }
            set {
                isAlive = value;
            }
        }

        public int RowNumber
        {
            get
            {
                return rowNumber;
            }
            set
            {
                rowNumber = value;
            }
        }

        public int ColumnNumber
        {
            get
            {
                return colNumber;
            }
            set
            {
                colNumber = value;
            }
        }
    }
}
