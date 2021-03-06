using Adventos.Logic;
using System;

namespace Adventos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Los adventos buranos");
            var input = -1;
            while (input == -1)
            {
                input = GetDay();
                switch (input)
                {
                    case 1:
                        var report = new Day1();
                        report.Process();
                        break;
                    case 2:
                        var report2 = new Day2();
                        report2.Process();
                        break;
                    case 3:
                        var report3 = new Day3();
                        report3.Process();
                        break;
                    case 4:
                        var report4 = new Day4();
                        report4.Process();
                        break;
                    case 5:
                        var report5 = new Day5();
                        report5.Process();
                        break;
                    case 6:
                        var report6 = new Day6();
                        report6.Process();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid day. Try again.");
                        break;
                }
                input = -1;
            }
        }
        static int Parse(string input)
        {
            var isValid = int.TryParse(input, out var number);
            if (!isValid)
                return -1;
            return number;
        }
        static int GetDay()
        {
            Console.WriteLine("Enter 1-25 for day specific solution, 0 to exit:");
            return Parse(Console.ReadLine());
        }


    }
}
