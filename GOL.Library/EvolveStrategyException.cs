using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GOL.Library
{
    [Serializable]
    public class EvolveStrategyException : System.Exception
    {
        // The default constructor needs to be defined
        // explicitly now since it would be gone otherwise.

        public EvolveStrategyException()
        {
        }

        public EvolveStrategyException(string message)
            : base(message)
        {
        }
    }
}
