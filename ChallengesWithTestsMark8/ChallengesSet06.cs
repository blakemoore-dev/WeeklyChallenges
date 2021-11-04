using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            foreach (var w in words)
            {
                if (ignoreCase == true)
                {
                    if (w.ToLower() == word)
                        return true;
                }
                else if (ignoreCase == false)
                {
                    if (w == word)
                        return true;
                }
            }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            throw new NotImplementedException();
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            throw new NotImplementedException();
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            throw new NotImplementedException();
        }
    }
}
