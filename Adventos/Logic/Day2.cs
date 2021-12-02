using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventos.Logic
{
    class Day2
    {
        private readonly List<string> _units;

        public Day2()
        {
            _units = FileUtils.ReadAsList("Day2.txt");
        }

        public void Process()
        {
            Console.WriteLine($"Part 1: {ChartCourse(_units)}");
            Console.WriteLine($"Part 2: {ChartComplexCourse(_units)}");
        }

        public static int ChartCourse(List<string> paths)
        {
            int forward = paths.Where(word => word.Contains("forward")).Select(word => int.Parse(word.Replace("forward ", ""))).Sum();
            int down = paths.Where(word => word.Contains("down")).Select(word => int.Parse(word.Replace("down ", ""))).Sum();
            int up = paths.Where(word => word.Contains("up")).Select(word => int.Parse(word.Replace("up ", ""))).Sum();
            return forward * (down - up);
        }
        public static int ChartComplexCourse(List<string> paths)
        {
            int aim = 0;
            int depth = 0;
            int hor = 0;
            foreach (string word in paths)
            {
                if (word.Contains("forward"))
                {
                    hor += int.Parse(word.Replace("forward ", ""));
                    depth += aim * int.Parse(word.Replace("forward ", ""));
                }
                if (word.Contains("down"))
                    aim += int.Parse(word.Replace("down ", ""));
                if (word.Contains("up"))
                    aim -= int.Parse(word.Replace("up ", ""));
            }
            return hor * depth;
        }
    }
}
