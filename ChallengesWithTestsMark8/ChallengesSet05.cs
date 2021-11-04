using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            while (true)
            {
                startNumber++;
                if (startNumber % n == 0)
                    return startNumber;
            }
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var b in businesses)
            {
                if (b.TotalRevenue == 0)
                    b.Name = "CLOSED";
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            var result = false;

            if (numbers == null)
                return false;
            if (numbers.Length == 1)
                result = true;


            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] >= numbers[i - 1])
                {
                    result = true;
                }
                else
                {
                    result = false;
                    break;
                }
            }
            return result;
            //return numbers == numbers.ToList().Skip(1).OrderBy(x => x).ToArray();
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0;

            var result = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0)
                {
                    result += numbers[i];
                }
            }

            return result;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0) return "";
            // Failed to solve with LINQ alone. Had to refer to answer branch for help. This did however solve 7/8 tests.
            //return string.Join(" ", words.Where(x => !string.IsNullOrWhiteSpace(x)).Select(x => x.Trim())) + ".";

            var str = "";

            foreach (var w in words)
            {
                if (w.Trim().Length > 0) str += w.Trim() + " ";
            }

            if (str.Length == 0) return "";

            str = str.Substring(0, str.Length - 1);
            str += ".";
            return str;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null)
                return new double[] { };
            // WANTED TO TRY SOME QUERY SYNTAX... MEH ¯\_(ツ)_/¯
            // I DON'T LIKE IT
            //return (from nums in elements
            //        where nums % 4 == 0
            //        select nums).ToArray();
            return elements.Where(x => x % 4 == 0).Select(x => x).ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                        return true;
                }
            }
            return false;
        }
    }
}
