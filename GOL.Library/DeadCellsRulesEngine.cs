using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GOL.Library.Interfaces;

namespace GOL.Library
{
    /// <summary>
    /// Class implementing the RULE for Dead cells.
    /// If number of alive cells around a dead cell is equal to 3, it returns true else false
    /// </summary>
    class DeadCellsRulesEngine :IRulesEngine
    {
        /// <summary>
        /// Execute function takes count of alive neighbours as input, executes the rules on it and returns back either true or false.
        /// </summary>
        /// <param name="_NumberofNeighbours"></param>
        /// <returns></returns>
        public bool ExecuteRule(int _NumberofNeighbours)
        {
            bool returnVal;
            if (_NumberofNeighbours == 3)
            {
                returnVal = true;
            }
            else
            {
                returnVal = false;
            }
            return returnVal;
        }
    }
}
