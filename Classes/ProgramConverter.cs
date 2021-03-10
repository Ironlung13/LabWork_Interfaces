using System;
using System.Collections.Generic;
using System.Text;

namespace LabWork_Interfaces.Classes
{
    public class ProgramConverter : Interfaces.IConvertible
    {
        public string ConvertToCSharp(string input)
        {
            //Convert to c#
            return "Converted to C#";
        }

        public string ConvertToVB(string input)
        {
            //Convert to VB
            return "Converted to VB";
        }
    }
}
