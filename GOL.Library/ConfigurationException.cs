using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GOL.Library
{
    [Serializable]
    public class ConfigurationException : System.Exception
    {
        // The default constructor needs to be defined
        // explicitly now since it would be gone otherwise.

        public ConfigurationException()
        {
        }

        public ConfigurationException(string message)
            : base(message)
        {
        }
    }

}
