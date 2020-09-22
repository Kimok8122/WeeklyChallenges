using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {


        public bool ArrayContainsAFalse(bool[] vals)
        {
            //throw new NotImplementedException();

            foreach (var item in vals)
            {
                if (item == false)
                {
                    return true;
                }
                
            }
            return false;
        }




        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            //throw new NotImplementedException();

            if(numbers == null)
            {
                return false;
            }

            var sum = 0;

            foreach (var num in numbers)
            {
                if (num % 2 != 0)
                {
                    sum += num;
                }

            }
            return ((sum % 2) != 0);
        }



        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            //throw new NotImplementedException();

            if (password == null)
            {
                return false;
            }

            var isUpper = password.Any(c => char.IsUpper(c));

            var isLower = password.Any(c => char.IsLower(c));

            var isNumber = password.Any(c => char.IsNumber(c));

            return isLower && isNumber && isUpper;
            
        }

        public char GetFirstLetterOfString(string val)
        {
            //throw new NotImplementedException();
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            //throw new NotImplementedException();
            return val[val.Length-1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            //throw new NotImplementedException();

            if (divisor == 0)
            {
                return 0;
            }

                decimal result = 0;

                result = dividend / divisor;

                return result;
        } 

        public int LastMinusFirst(int[] nums)
        {
            throw new NotImplementedException();
        }

        public int[] GetOddsBelow100()
        {
            throw new NotImplementedException();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            throw new NotImplementedException();
        }
    }
}
