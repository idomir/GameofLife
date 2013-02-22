using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace GOL.Library
{
    /// <summary>
    /// Static class for reading configuration data from App.config configuration file.
    /// </summary>
    public static class ConfigManager
    {
        /// <summary>
        /// GetStringLiterals takes a Key as an argument and returns back the corresponding value for it from configuration file.
        /// </summary>
        /// <param name="_inputString"></param>
        /// <returns></returns>
        public static string GetStringLiterals(string _inputString)
        {
            string str = ConfigurationManager.AppSettings.Get(_inputString);
            if (string.IsNullOrEmpty(str))
                throw new ConfigurationException(ConfigurationManager.AppSettings.Get("ExceptionString"));

            return str;
        }
    }
}
