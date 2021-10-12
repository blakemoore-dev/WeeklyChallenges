using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetterOrDigit(c);
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
            return numbers == null || numbers == new double[] { } ? 0 : numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            throw new NotImplementedException();
        }

        public int Sum(int[] numbers)
        {
            var sum = 0;
            foreach (var n in numbers)
            {
                sum += n;
            }
            return numbers == null || numbers == new int[] { } ? 0 : sum;
        }

        public int SumEvens(int[] numbers)
        {
            var evens = new int[] { };
            foreach (var n in numbers)
            {
                if (n % 2 == 0)
                    evens.Append(n);
            }
            return evens.Sum();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            throw new NotImplementedException();
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            throw new NotImplementedException();
        }
    }
}
