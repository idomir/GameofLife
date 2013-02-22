using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GOL.Library.Interfaces;

namespace GOL.Library
{
    /// <summary>
    /// The class is reponsible for changing the values of the cells as true or false immidiately as they are evaluated.
    /// </summary>
    public class InPlaceEvolveStrategy :IEvolveStrategy
    {
        private Grid grid = null;
        
        public InPlaceEvolveStrategy(Grid _grid)
        {
            this.grid = _grid;
        }
        
        public void EvolveStrategy(Cell _cell, bool _isAlive)
        {
            grid[_cell.RowNumber, _cell.ColumnNumber].RowNumber = _cell.RowNumber;
            grid[_cell.RowNumber, _cell.ColumnNumber].ColumnNumber = _cell.ColumnNumber;
            grid[_cell.RowNumber, _cell.ColumnNumber].IsAlive = _isAlive;
        }

        public void UpgradeGrid()
        {
            throw new EvolveStrategyException();
        }
    }
}
