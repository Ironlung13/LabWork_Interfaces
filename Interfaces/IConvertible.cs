using System;
using System.Collections.Generic;
using System.Text;

namespace LabWork_Interfaces.Interfaces
{
    public interface IConvertible
    {
        public string ConvertToCSharp(string input);
        public string ConvertToVB(string input);
    }
}
