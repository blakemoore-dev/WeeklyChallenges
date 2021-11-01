using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int result = 0;
            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                    result += num;
                else result -= num;
            }
            return result;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int[] stringLengths = { str1.Length, str2.Length, str3.Length, str4.Length };
            return stringLengths.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            return new int[] { number1, number2, number3, number4 }.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 > sideLength3 &&
                sideLength1 + sideLength3 > sideLength2 &&
                sideLength3 + sideLength2 > sideLength1)
                return true;
            else return false;
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out double result);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var count = 0;
            foreach (var o in objs)
            {
                if (o == null)
                    count++;
            }
            return count <= objs.Length / 2 ? false : true;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null)
                return 0;
            else if (numbers.Where(x => x % 2 == 0).Sum() == 0)
                return 0;
            else return numbers.Where(x => x % 2 == 0).Average();
        }

        public int Factorial(int number)
        {
            if (number == 0)
                return 1;

            if (number < 0)
                throw new ArgumentOutOfRangeException();
            for (int i = number-1; i > 0; i--)
            {
                number *= i;
            }
            return number;
        }
    }
}
