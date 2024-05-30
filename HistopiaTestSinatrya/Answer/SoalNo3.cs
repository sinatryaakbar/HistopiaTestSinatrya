using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistopiaTestSinatrya.Answer
{
    public static class SoalNo3
    {
        public static string GetHighestPalindrome(string InputString, int k)
        {
            if (InputString.Length <= 1) //Condition if Input String is less than equals 1
                return (k > 0 && !string.IsNullOrWhiteSpace(InputString)) ? "9" : InputString;

            char firstChar = InputString[0]; //Get First Char
            char lastChar = InputString[InputString.Length - 1]; //Get Last Char
            
            if (firstChar == lastChar) //Compare First Char equals Last Char
            {
                if (k > 1 && firstChar != '9')  //Check if K is greater than 1 and char not equals 0 than replace first and last char with 9
                    return '9' + GetHighestPalindrome(InputString.Substring(1, InputString.Length - 2), k - 2) + '9'; //recursive here

                return firstChar + GetHighestPalindrome(InputString.Substring(1, InputString.Length - 2), k) + lastChar; //recursive here
            }
            else if (k > 0) //First Char is not equals Last Char and Check if K is greater than 0
            {
                if (firstChar != '9' && lastChar != '9')
                    k -= 2; //Skip Next K
                else if (firstChar != '9' || lastChar != '9')
                    k -= 1; //Next K

                return "9" + GetHighestPalindrome(InputString.Substring(1, InputString.Length - 2), k) + "9"; //recursive here
            }
            else //First Char is not equals Last Char and K is less than equals than 0
            {
                return "-1";
            }
        }
    }
}
