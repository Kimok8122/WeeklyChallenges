using System;

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
            throw new NotImplementedException();

            

            //string shortString = new string [] [str1, str2, str3, str4];

            //foreach (string name in shortStrings)
            //{
            //    if (name.Length < strings.Length)
            //    {
            //        strings = name;
            //    }
            //}

            //return strings;

            
        }





        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            throw new NotImplementedException();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            throw new NotImplementedException();
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public int Factorial(int number)
        {
            throw new NotImplementedException();
        }
    }
}
