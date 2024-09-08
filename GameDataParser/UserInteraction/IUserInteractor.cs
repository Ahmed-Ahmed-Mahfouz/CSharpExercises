﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDataParser.UserInteraction
{
    internal interface IUserInteractor
    {
        string ReadValidFilePath();
        void PrintMessage(string message);
        void PrintError(string message);
    }
}
