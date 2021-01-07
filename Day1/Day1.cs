using System.Collections.Generic;

namespace AdventCalendar.Day1
{
    public class Day1
    {
        public IEnumerable<(int, int)> Puzzle1(int[] numbers)
        {
            for (var i = 0; i < numbers.Length; i++)
            {
                for (var j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == 2020)
                    {
                        yield return (numbers[i], numbers[j]);
                    }
                }
            }
        }

        public IEnumerable<(int, int, int)> Puzzle2(int[] numbers)
        {
            for (var i = 0; i < numbers.Length; i++)
            {
                for (var j = i + 1; j < numbers.Length; j++)
                {
                    for (var k = 2; k < numbers.Length; k++)
                    {
                        if (numbers[i] + numbers[j] + numbers[k] == 2020)
                        {
                            yield return (numbers[i], numbers[j], numbers[k]);
                        }
                    }
                }
            }
        }
    }
}