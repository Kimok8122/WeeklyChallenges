﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {


        public int AddEvenSubtractOdd(int[] numbers)
        {
            //throw new NotImplementedException();

            var odd = 0;
            var even = 0;

            foreach (var num in numbers)
            {
                if (num % 2 != 0)
                {
                    odd += num;
                }
                else
                {
                    even += num;
                }

            }
            return even - odd;
        }





        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            //throw new NotImplementedException();



            var strings = new int[] { str1.Length, str2.Length, str3.Length, str4.Length };

            return strings.Min();

            //return x.Length;

        }





        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            // throw new NotImplementedException();

            var numArray = new int[4] { number1, number2, number3, number4 };

            return numArray.Min();
           
        }





        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            //throw new NotImplementedException();

            biz.Name = "TrueCoders";
        }






        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            //throw new NotImplementedException();
            return sideLength1 + sideLength2 > sideLength3 && sideLength2 + sideLength3 > sideLength1 && sideLength3 + sideLength1 > sideLength2;
        }





        public bool IsStringANumber(string input)
        {
            //throw new NotImplementedException();
            double x;
            return double.TryParse(input, out x);
        }




        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            //throw new NotImplementedException();

            int count = 0;
            for (int i = 0; i < objs.Length; i++)
            {
                if (objs[i] == null)
                {
                    count++;
                }
            }
            return count > objs.Length / 2;
        }






        public double AverageEvens(int[] numbers)
        {
            //throw new NotImplementedException();

            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            var count = 0;
            double sum = 0;

            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                {
                    count++;
                    sum += item;
                }
            }

            if (sum == 0)
            {
                return 0;
            }

            return sum / count;
            //return answer; 
        }

        public int Factorial(int number)
        {
            //throw new NotImplementedException();

            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            int result = 1;
            while (number != 1)
            {
                result = result * number;
                number = number - 1;
            }
            if (result == 0)
            {
                return 1;
            }
            return result;
        }
    }
}
