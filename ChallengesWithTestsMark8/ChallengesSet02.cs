using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            var count = 0;
            foreach (var v in vals)
                count++;
            return count % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            return numbers == null || numbers.Count() == 0 /*numbers == new double[] { }*/ ? 0 : numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length < str2.Length ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            var sum = 0;
            if (numbers == null)
                return 0;
            else
                foreach (var n in numbers)
                    sum += n;
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            var evens = new List<int>();
            if (numbers == null)
                return 0;
            else
            {
                foreach (var n in numbers)
                {
                    if (n % 2 == 0)
                        evens.Add(n);
                }
            }
            return evens.Sum();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            return numbers == null ? false : (numbers.Sum() % 2 != 0);
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            return number >= 0 ? number / 2 : 0;
        }
    }
}
