using System;
using System.Collections.Generic;
using System.Text;

namespace LabWork_Interfaces.Classes
{
    public class ProgramHelper : ProgramConverter, Interfaces.ICodeChecker
    {
        public bool CheckCodeSyntax(string input, string language)
        {
            //Check code;
            return true;
        }
    }
}
