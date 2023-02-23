using System;
using System.Collections.Generic;
using System.Text;

namespace SF_25.PLL
{
    public static class KeyReader
    {
        public static string KeyRead()
        {
            ConsoleKeyInfo keyInfo;

            string command = "";

            keyInfo = Console.ReadKey();

            command += keyInfo.KeyChar;

            if (keyInfo.Key == ConsoleKey.End)
            {
                return "End";
            }
                
            do
            {
                keyInfo = Console.ReadKey();

                command += keyInfo.KeyChar;       
            }
            while (keyInfo.Key != ConsoleKey.Enter);

            return command;
        }
    }
}
