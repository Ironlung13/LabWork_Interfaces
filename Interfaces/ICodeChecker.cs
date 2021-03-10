using System;
using System.Collections.Generic;
using System.Text;

namespace LabWork_Interfaces.Interfaces
{
    public interface ICodeChecker
    {
        public bool CheckCodeSyntax(string input, string language);
    }
}
