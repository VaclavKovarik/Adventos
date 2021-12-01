using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventos.Logic
{
    class Day1
    {
        private readonly int[] _units;

        public Day1()
        {
            _units = FileUtils.ReadFile("Day1.txt").Select(x => int.Parse(x)).ToArray();
        }

        public void Process()
        {
            Console.WriteLine($"Part 1: {GetIncreases()}");
            Console.WriteLine($"Part 2: {GetGroupedIncreases()}");
        }

        private int GetIncreases()
        {
            return GetIncreases(_units);
        }

        private int GetIncreases(int[] entries)
        {
            return entries.Select((_, i) => i < entries.Length - 1 && entries[i + 1] > entries[i]).Count(x => x);
        }

        private int GetGroupedIncreases()
        {
            return GetIncreases(_units.Select((_, i) => i < _units.Length - 2 ? _units[i..(i + 3)].Sum() : 0).ToArray());
        }
    }
}
