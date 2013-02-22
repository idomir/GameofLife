using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GOL.Library.Interfaces;

namespace GOL.Library
{
    /// <summary>
    /// Class implementing the RULE for Alive cells. 
    /// If number of alive cells around a alive cell is less than 2 or greater than 3, it returns false else true
    /// </summary>
    public class AliveCellsRulesEngine : IRulesEngine
    {
        /// <summary>
        /// Execute function takes count of alive neighbours as input, executes the rules on it and returns back either true or false.
        /// </summary>
        /// <param name="_NumberofNeighbours"></param>
        /// <returns></returns>
        public bool ExecuteRule(int _NumberofNeighbours)
        {
            bool returnVal;
            if (_NumberofNeighbours < 2)
            {
                returnVal = false;
            }
            else if (_NumberofNeighbours == 2 ||
                _NumberofNeighbours == 3)
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
