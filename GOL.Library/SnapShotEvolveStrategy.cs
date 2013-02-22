using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GOL.Library.Interfaces;

namespace GOL.Library
{
    /// <summary>
    /// The class is reponsible for changing the values of the cells as true or false after all the cells have been evaluated..
    /// </summary>
    public class SnapShotEvolveStrategy : IEvolveStrategy
    {
        private Grid grid = null;
        private Grid evolvedGrid = null;
        public SnapShotEvolveStrategy(Grid _grid)
        {
            this.grid = _grid;
            this.evolvedGrid = new Grid(grid.Length, grid.Breath);
        }

        public void EvolveStrategy(Cell _cell, bool _isAlive)
        {
            evolvedGrid[_cell.RowNumber, _cell.ColumnNumber].RowNumber = _cell.RowNumber;
            evolvedGrid[_cell.RowNumber, _cell.ColumnNumber].ColumnNumber = _cell.ColumnNumber;
            evolvedGrid[_cell.RowNumber, _cell.ColumnNumber].IsAlive = _isAlive;
            
        }

        /// <summary>
        /// This function returns the new updated grid after a generation
        /// </summary>
        /// <returns></returns>
        public Grid GetEvolvedGrid()
        {
            return evolvedGrid;
        }

        /// <summary>
        /// The function updates a grid after a generation
        /// </summary>
        public void UpgradeGrid()
        {
            for (int i = 0; i < evolvedGrid.Length; i++)
            {
                for (int j = 0; j < evolvedGrid.Breath; j++)
                {
                    grid[i, j].IsAlive = evolvedGrid[i, j].IsAlive;
                    grid[i, j].RowNumber = evolvedGrid[i, j].RowNumber;
                    grid[i, j].ColumnNumber = evolvedGrid[i, j].ColumnNumber;
                }
            }
        }
    }
}
