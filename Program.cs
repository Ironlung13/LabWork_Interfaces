using System;
using LabWork_Interfaces.Classes;

namespace LabWork_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Whatever.";
            string language = "C#";
            ProgramConverter[] array = { new ProgramConverter(), new ProgramConverter(), new ProgramHelper(), new ProgramHelper() };
            foreach(var item in array)
            {
                if (item is Interfaces.ICodeChecker)
                {
                    Interfaces.ICodeChecker check = item as Interfaces.ICodeChecker;
                    if (check.CheckCodeSyntax(input, language))
                    {
                        Console.WriteLine(item.ConvertToVB(input));
                    }
                    else
                    {
                        Console.WriteLine(item.ConvertToCSharp(input)); 
                    }
                }
                else
                {
                    Console.WriteLine(item.ConvertToCSharp(input));
                    Console.WriteLine(item.ConvertToVB(input));
                }
            }
        }
    }
}
