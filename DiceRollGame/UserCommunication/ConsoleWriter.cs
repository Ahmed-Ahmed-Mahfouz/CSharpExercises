using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollGame.UserCommunication
{
    internal static class ConsoleWriter
    {
        public static void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
