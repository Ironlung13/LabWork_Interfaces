using System;
using System.Collections.Generic;
using System.Text;

namespace LabWork_Interfaces.Classes
{
    public class ProgramHelper : Interfaces.IConvertible, Interfaces.ICodeChecker
    {
        public bool CheckCodeSyntax(string input, string language)
        {
            //Check code;
            return true;
        }

        public string ConvertToCSharp(string input)
        {
            //Convert code to C#
            return "Success";
        }

        public string ConvertToVB(string input)
        {
            //Convert code to VB
            return "Success";
        }
    }
}
