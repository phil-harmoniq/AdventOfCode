using AdventOfCode.Y2019.Puzzles.Generic;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Y2019.Puzzles
{
    public class Puzzle04 : IPuzzle
    {
        public int Part1(string[] input)
        {
            var split = input[0].Split('-');
            var minimum = int.Parse(split[0]);
            var maximum = int.Parse(split[1]);

            var possiblePasscodes = new List<int>();
            
            for (var i = minimum; i <= maximum; i++)
            {
                if (HasRepeatingNumber(i) && IsAscending(i))
                {
                    possiblePasscodes.Add(i);
                }
            }

            return possiblePasscodes.Count;
        }

        public int Part2(string[] input)
        {
            var split = input[0].Split('-');
            var minimum = int.Parse(split[0]);
            var maximum = int.Parse(split[1]);

            var possiblePasscodes = new List<int>();

            for (var i = minimum; i <= maximum; i++)
            {
                if (HasRepeatingNumber(i) && OneRepeatOnlyHappensOnce(i) && IsAscending(i))
                {
                    possiblePasscodes.Add(i);
                }
            }

            return possiblePasscodes.Count;
        }

        private bool HasRepeatingNumber(int input)
        {
            var stringInput = input.ToString();

            for (var i = 0; i < stringInput.Length - 1; i++)
            {
                if (stringInput[i] == stringInput[i + 1])
                {
                    return true;
                }
            }

            return false;
        }

        private bool OneRepeatOnlyHappensOnce(int input)
        {
            var stringInput = input.ToString();
            var singleRepeat = 0;
            var multiRepeat = 0;
            var intSplit = stringInput.Select(x => int.Parse(x.ToString())).ToArray();

            for (var i = 1; i < intSplit.Length;)
            {
                var repeatCount = HowManyOfCurrentCharacter(intSplit[i..], intSplit[i]);
                if (repeatCount == 2)
                {
                    singleRepeat++;
                }
                else if (repeatCount > 2)
                {
                    multiRepeat++;
                }
                i += repeatCount;
                //if (stringInput[i] == stringInput[i + 1] && stringInput[i] == stringInput[i + 2])
                //{
                //    multiRepeat++;
                //}
                //else if (stringInput[i] == stringInput[i + 1] && stringInput[i] != stringInput[i + 2])
                //{
                //    singleRepeat++;
                //}
            }

            //if (multiRepeat > 0 && singleRepeat == 0)
            //{
            //    return false;
            //}

            return singleRepeat > 0;
        }

        private int HowManyOfCurrentCharacter(int[] intArray, int previous)
        {
            if (intArray[0] == previous)
            {
                if (intArray.Length > 1)
                {
                    return 1 + HowManyOfCurrentCharacter(intArray[1..], intArray[0]);
                }
                else
                {
                    return 1;
                }
            }

            return 0;
        }

        private bool IsAscending(int input)
        {
            var stringInput = input.ToString();
            var intSplit = stringInput.Select(c => int.Parse(c.ToString())).ToArray();

            for (var i = 0; i < intSplit.Length - 1; i++)
            {
                if (intSplit[i] > intSplit[i + 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
