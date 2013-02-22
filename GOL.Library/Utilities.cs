using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GOL.Library
{
    public enum Alignment {Left, Center, Right}
    public enum LineBreaks {Single, Double}
    public enum EvolveType { InPlace, SnapShot }

    public class Utilities
    {

       public static string[] GetStringArrayFromDelimitedString(string _inputString, char[] _delimitedString )
       {
           string[] stringArray = _inputString.Split(_delimitedString);
           return stringArray;
       }

       public static bool isNumeric(string _inputstring)
       {
           int i;
           if (int.TryParse(_inputstring, out i))
               return true;

           return false;

       }

        public static string StringAlignment(string _inputString, Alignment _align,  LineBreaks _lineBreaks)
        {
            string outputString;

            if (_align == Alignment.Left)
                outputString = _inputString;
            else if (_align == Alignment.Center)
                outputString = "\t\t\t" + _inputString;
            else if (_align == Alignment.Right)
                outputString = "\t\t\t\t\t\t" + _inputString;
            else
                outputString = _inputString;

            
            if (_lineBreaks == LineBreaks.Double)
                outputString = outputString + "\n";
            
            return outputString;
        }
    }
}
