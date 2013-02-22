using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GOL.Library.Interfaces;

namespace GOL.Library
{
    public class NeighbourStategy : INeighbourStrategy
    {
        private Grid grid;

        public NeighbourStategy(Grid _grid)
        {
            this.grid = _grid;
        }

        public int GetCountofCellNeighbours(Cell _cell)
        {
            int neighbourCounter = 0;
            for (int innerRow = -1; innerRow <= 1; innerRow++)
            {
                for (int innerColumn = -1; innerColumn <= 1; innerColumn++)
                {
                    if (innerRow == 0 && innerColumn == 0) continue;
                    if (!(innerRow + _cell.RowNumber <= -1 || innerColumn + _cell.ColumnNumber <= -1 || _cell.RowNumber + innerRow >= grid.Length || _cell.ColumnNumber + innerColumn >= grid.Breath))
                    {
                        if (grid[_cell.RowNumber + innerRow, _cell.ColumnNumber + innerColumn].IsAlive == true)
                        {
                            neighbourCounter++;
                        }
                    }
                }
            }
            return neighbourCounter;
        }
    }
}
