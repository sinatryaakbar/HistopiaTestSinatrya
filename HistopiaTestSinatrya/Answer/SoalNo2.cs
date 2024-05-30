using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistopiaTestSinatrya.Answer
{
    public static class SoalNo2
    {
        public static string GetBalancedBracket(string InputString)
        {
            var queue = new Stack<char>(); //using stack, Effective for LIFO (Last In First Out), and efficient for memory
            if (InputString.Length == 0) return "NO"; //Validate Lenght of Input String

            foreach (var chr in InputString) //Loop To Compare
            {                
                switch (chr) //Switch is more efficient for this condition.
                {
                    case ' ': break; //Skip Whitespace
                    case '(':
                    case '[':
                    case '{':
                        queue.Push(chr); // Store Any Open Bracket to Last Stack
                        break;
                    case ')': //Looking for open bracket '('
                        if (
                            queue.Count == 0 || //queue == 0 : indicate not contains any open bracket & Prevent to pop queue
                            queue.Pop() != '(' //Pop: Remove & Get Last Char to compare with current Char
                            ) 
                            return "NO"; //not match with open bracket '('
                        break;
                    case ']': //Looking for open bracket '['
                        if (
                            queue.Count == 0 || //queue == 0 : indicate not contains any open bracket & Prevent to pop queue
                            queue.Pop() != '[' //Pop: Remove & Get Last Char to compare with current Char
                            ) 
                            return "NO"; //not match with open bracket '['
                        break;
                    case '}': //Looking for open bracket '{'
                        if (
                            queue.Count == 0 || //queue == 0 : indicate not contains any open bracket & Prevent to pop queue
                            queue.Pop() != '{' //Pop: Remove & Get Last Char to compare with current Char
                            )  
                            return "NO"; //not match with open bracket '{'
                        break;
                    default: //Indicate not allowed Char
                        return $"{chr} Is Invalid Character..!"; //Validate Allowed Char
                }
            }

            return (queue.Count == 0) ? "YES" : "NO";
        }
    }
}
