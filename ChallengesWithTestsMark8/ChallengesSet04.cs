using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            return numbers.Where(x => x % 2 == 0).Sum() - numbers.Where(x => x % 2 != 0).Sum();
            
            //Long way
            //int result = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //        result += numbers[i];
            //    if (numbers[i] % 2 != 0)
            //        result -= numbers[i];
            //}
            //return result;
            
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            List<int> list = new List<int>() { str1.Length, str2.Length, str3.Length, str4.Length };
            return list.Min();

            //Long way
            //int w = str1.Length;
            //int x = str2.Length;
            //int y = str3.Length;
            //int z = str4.Length;
            //if (w <= x && w <= y && w <= z)
            //    return w;
            //if (x <= w && x <= y && x <= z)
            //    return x;
            //if (y <= w && y <= x && y <= z)
            //    return y;
            //else
            //    return z;
        }
        

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int set1 = Math.Min(number1, number2);
            int set2 = Math.Min(number3, number4);
            return Math.Min(set1, set2);
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if(sideLength1 <= 0 || sideLength2 <= 0 || sideLength3 <= 0)
            return false;
            else if ((sideLength1 + sideLength2) <= sideLength3 ||
                (sideLength1 + sideLength3) <= sideLength2 ||
                (sideLength2 + sideLength3) <= sideLength1)
                return false;
            else
                return true;
        }

        public bool IsStringANumber(string input)
        {
            bool x = Int32.TryParse(input, out _);
            bool y = double.TryParse(input, out _);
            return (x || y);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            return objs.Where(x => x == null).Count() > objs.Where(x => x != null).Count();

            //Long way
            //int nullCount = 0;
            //int objCount = 0;
            //foreach (var item in objs)
            //{
            //    if (item == null)
            //        nullCount++;
            //    else
            //        objCount++;
            //}
            //return nullCount > objCount;
        }

        public double AverageEvens(int[] numbers)
        {
            return numbers == null || numbers.Length == 0 || numbers.Where(x => x % 2 == 0).Count() == 0 ? 0 : numbers.Where(x => x % 2 == 0).Average();

            //Long way
            //double sum = 0;
            //double count = 0;

            //if (numbers == null)
            //    return 0;
            //else if (numbers.Length == 0)
            //    return 0;
            //else
            //{
            //    foreach (var num in numbers)
            //    {
            //        if (num % 2 == 0)
            //        {
            //            sum += num;
            //            count++;
            //        }
            //    }
            //    if (count == 0)
            //        return 0;
            //}
            //return sum / count;
        }

        public int Factorial(int number)
        {
            int count = 1;
            int result = 1;

            if (number < 0)
                throw new ArgumentOutOfRangeException();
            while (count < number)
            {
                count++;
                result *= count;
            }
            return result;
        }
}
}
