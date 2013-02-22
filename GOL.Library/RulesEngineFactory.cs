using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GOL.Library.Interfaces;

namespace GOL.Library
{
    /// <summary>
    /// Factory class for creating rule engines concrete classes.
    /// </summary>
    class RulesEngineFactory : IRulesFactory
    {

        public IRulesEngine GetRules(bool _isAlive)
        {
            if (_isAlive == true)
                return new AliveCellsRulesEngine();
            else 
                return new DeadCellsRulesEngine();
               
        }
    }
}
