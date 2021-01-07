using System;
using System.IO;
using System.Linq;

namespace AdventCalendar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Happy Advent!");
            Day1();
            Day2();
            Day3();
            Console.ReadLine();
        }

        private static void Day3()
        {
            Console.WriteLine("###################");
            Console.WriteLine("Day3");
            Console.WriteLine("###################");
            var input = File.ReadAllLines(@"..\..\..\Day3\input.txt").ToArray();
            var day3 = new Day3.Day3(input);
            var puzzle1Result = day3.Puzzle1();
            Console.WriteLine($"Puzzle1: found results:{puzzle1Result}");
            var puzzle2Result = day3.Puzzle2();
            Console.WriteLine($"Puzzle2: found results:{puzzle2Result}");
        }

        private static void Day2()
        {
            Console.WriteLine("###################");
            Console.WriteLine("Day2");
            Console.WriteLine("###################");
            var input = File.ReadAllLines(@"..\..\..\Day2\input.txt").ToArray();
            var day2 = new Day2.Day2(input);
            var puzzle1Result = day2.Puzzle1();
            Console.WriteLine($"Puzzle1: found results:{puzzle1Result}");
            var puzzle2Result = day2.Puzzle2();
            Console.WriteLine($"Puzzle2: found results:{puzzle2Result}");
        }

        private static void Day1()
        {
            Console.WriteLine("###################");
            Console.WriteLine("Day1");
            Console.WriteLine("###################");
            var day1 = new Day1.Day1();
            var numbers = File.ReadAllLines(@"..\..\..\Day1\Numbers.txt").Select(int.Parse).ToArray();
            var puzzle1Result = day1.Puzzle1(numbers);
            Console.WriteLine("Puzzle1:");
            foreach (var (num1, num2) in puzzle1Result)
            {
                Console.WriteLine($"Found numbers:{num1},{num2} result:{num1 * num2}");
            }
            Console.WriteLine("Puzzle2:");
            var puzzle2Result = day1.Puzzle2(numbers);
            foreach (var (num1, num2,num3) in puzzle2Result)
            {
                Console.WriteLine($"Found numbers:{num1},{num2},{num3} result:{num1 * num2 * num3}");
            }
        }
    }
}
