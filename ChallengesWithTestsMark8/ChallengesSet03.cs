using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Numerics;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return vals.Contains(false);
            
            //Long way
            //bool conditional = false;
            //for (int i = 0; i < vals.Length; i++)
            //{
            //    if (vals[i] == false)
            //    {
            //        conditional =  true;
            //    }
            //}
            //return conditional;
            
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            return numbers == null ? false : numbers.Where(x => x % 2 != 0).Sum() % 2 != 0;
            
            //Long way
            //int x = 0;
            //bool isOdd;
            //if (numbers == null)
            //{
            //    return false;
            //}
            //else
            //{
            //    foreach (var num in numbers)
            //    {
            //        x += num;
            //    }
            //    isOdd = x % 2 == 0 ? false : true;
            //    return isOdd;
            //}
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool hasUpLowNum = true;
            var hasUp = password.Any(char.IsUpper);
            var hasLow = password.Any(char.IsLower);
            var hasNum = password.Any(char.IsDigit);
            hasUpLowNum = (hasUpLowNum == hasUp && hasUpLowNum == hasLow &&
                hasUpLowNum == hasNum);
            return hasUpLowNum;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];   
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            var quotient = dividend / divisor;
            return quotient;
        }

        public int LastMinusFirst(int[] nums)
        {
            //var x = nums[nums.Length - 1];
            //var y = nums[0];
            //return x - y;

            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int count = 1;
            int[] oddsBelow = new int[50];
            for (int i = 0; i < oddsBelow.Length; i++)
            {
                oddsBelow[i] = count;
                count += 2;
            }
            return oddsBelow;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }

        }
    }
}
