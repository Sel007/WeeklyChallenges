using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if(vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0 ? true : 
                false;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0 ? true : false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            return numbers == null || numbers.Count() < 1 ? 0
                : numbers.Max() + numbers.Min(); 
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length > str2.Length 
                ? str2.Length : str1.Length;
        }

        public int Sum(int[] numbers)
        {
            return numbers == null ? 0 : numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            return numbers == null ? 0
                : numbers.Where(x => x % 2 == 0).Sum();
        }

        public bool IsSumOdd(List<int> numbers)

        {
            if (numbers == null)
                return false;
            int sum = numbers.Sum();
            if (sum % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            return number <= 0 ? 0 : number / 2;
        
            //Long way:
        //    if (number < 0)
        //    {
        //        return 0;
        //    } 
        //    int i = 0;
        //    int oddCounter = 0;
        //    while (i < number)
        //    {
        //        if (i %2 != 0)
        //        {
        //            oddCounter++;
        //        }
        //        i++;
        //    }
        //    return oddCounter;
        }
    }
}
