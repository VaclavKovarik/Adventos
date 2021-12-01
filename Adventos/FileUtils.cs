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
    }
}
