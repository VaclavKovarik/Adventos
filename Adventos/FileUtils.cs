using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Adventos
{
    class FileUtils
    {
        public static string[] ReadFile(string filename)
        {
            return File.ReadAllLines($"Input/{filename}");
        }

        public static string ReadRaw(string filename)
        {
            return File.ReadAllText($"Input/{filename}");
        }
        public static List<string> ReadAsList(string filename)
        {
            var logFile = File.ReadAllLines($"Input/{filename}");
            return new List<string>(logFile);
        }
    }
}
