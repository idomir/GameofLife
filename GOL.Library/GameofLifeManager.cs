using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GOL.Library.Interfaces;

namespace GOL.Library
{
    /// <summary>
    /// This is the Manager class for Game of Life Program and is the core class acting as a Facade to synchronize the different activities like getting neighbours, 
    /// invoking rules based on retuned number of neighbours and finally calling the evolve strategy to update the grid with new values for cell.
    /// </summary>
    public class GameofLifeManager
    {
        private Grid grid = null;
        private INeighbourStrategy neighbour = null;
        private EvolveType evolveType;
        private IEvolveStrategy evolveStrategy = null;


        /// <summary>
        /// Constructor taking a Grid a input and evolvetype as parameter. Evolve type could be inplace or Snapshot
        /// </summary>
        /// <param name="_grid"></param>
        /// <param name="_evolveType"></param>
        public GameofLifeManager(Grid _grid, EvolveType _evolveType)
        {
            this.grid = _grid;
            this.neighbour = new NeighbourStategy(_grid);
            this.evolveType = _evolveType;

            if (evolveType == EvolveType.SnapShot)
                evolveStrategy = new SnapShotEvolveStrategy(grid);
            else if (evolveType == EvolveType.InPlace)
                evolveStrategy = new InPlaceEvolveStrategy(grid);

        }
        
        /// <summary>
        /// The core function that executes to create a grid with updates from a generation
        /// </summary>
        public void EmulateGOL()
        {
            try
            {
                for (int i = 0; i < grid.Length; i++)
                {
                    for (int j = 0; j < grid.Breath; j++)
                    {
                        bool retval;
                        int counter = 0;

                        counter = neighbour.GetCountofCellNeighbours(grid[i, j]); //Get the count of neighbouring alive cells

                        IRulesFactory f = new RulesEngineFactory(); //Factory for creating either the alive or dead cell rules engine.
                        IRulesEngine E = f.GetRules(grid[i, j].IsAlive); //If current cell is alive then use AliveCellsRulesEngine else DeadCellsRulesEngine
                        retval = E.ExecuteRule(counter); //Execute the rule and get the new value for the current cell

                        evolveStrategy.EvolveStrategy(grid[i, j], retval); //using EvolveStrategy to either update current cell inplace or update after all cells are evaluated.

                    }

                }
            }
            catch (IndexOutOfRangeException ex)
            {
                throw new ApplicationException(ConfigManager.GetStringLiterals("ExceptionString"));
            }

            try
            {
                evolveStrategy.UpgradeGrid(); 
            }
            catch (EvolveStrategyException ex)
            { 
                //Log this message into a log destination
                
            }

        }

    }
}
