﻿using System;
using System.IO;

namespace OfferZenDiTutorial
{
    public class FileLogger : ILogger
    {
        private const string FileName = "Calculator.log";
        private readonly string _newLine = Environment.NewLine;

        public void WriteLine(string message)
        {
            File.AppendAllText(FileName, $"{message}{_newLine}");
        }
    }
}
