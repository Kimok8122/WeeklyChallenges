using System;
using System.Collections.Generic;
using System.Linq;

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

            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }



            //throw new NotImplementedException();
        }

        public bool IsNumberEven(int number)

        {
            return number % 2 == 0;


            //throw new NotImplementedException();
        }


        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
            //throw new NotImplementedException();
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {

            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            else
            {
                var min = numbers.Min();
                var max = numbers.Max();
                return min + max;
            }


            //throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {


            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            return str2.Length;


            //throw new NotImplementedException();
        }

        public int Sum(int[] numbers)
        {
            var total = 0;

            if (numbers == null)
            {
                return 0;
            }


            foreach (var item in numbers)
            {

                total += item;
            }
            return total;


            //throw new NotImplementedException();
        }

        public int SumEvens(int[] numbers)
        {
            var total = 0;

            if (numbers == null)
            {
                return 0;
            }


            foreach (var item in numbers)
            {
               if (item % 2 == 0)
                {
                    total = item + total;
                }
         
            }
            return total;

            //throw new NotImplementedException();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            var total = 0;

            if (numbers == null)
            {
                return false;
            }


            foreach (var item in numbers)
            {       
                
             total += item;

            }
            if (total % 2 == 0 )
            {
              return false;
            }
            return true;
            

            //throw new NotImplementedException();
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {

            if (number < 0)
            {
                return 0;
            }
            return number / 2;
            //throw new NotImplementedException();
        }










    }



}

