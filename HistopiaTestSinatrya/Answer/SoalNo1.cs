using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HistopiaTestSinatrya.Answer
{
    public static class SoalNo1
    {
        public static IEnumerable<string> GetWeightedStrings(string InputString, List<int> queries)
        {
            var hashWeight = new HashSet<int>(); //Collect Weight
            char lastChr = char.MinValue; //To Store Current Char to Compare with Next Char
            int cntDuplicate = 0; //++ if Last Char equal Current Char
            int MinChar = ('a') - 1; //Get ASCII Value of char
            InputString = InputString.ToLower(); //Set string to lower case

            foreach (var chr in InputString) //Loop to collect Weight Of Input String
            {
                if (char.IsLetter(chr)) //Check if chr is letter, if Char is not letter, skip measure weight
                {
                    if (chr != lastChr) //not equals logic
                    {
                        cntDuplicate = 1; //reset cntDuplicate
                        lastChr = chr; //reset lastChr
                    }
                    else //equals
                        cntDuplicate++; //compare chr with last char
                    hashWeight.Add((chr - MinChar) * cntDuplicate); //strore weight Of Char and multiply with Count Duplicate
                }
            }

            var result = new List<string>(); //To Store Result Query
            foreach (var query in queries) //Loop to Compare Weight Of Char with Query
            {
                result.Add(hashWeight.Contains(query) ? "Yes" : "No");
            }

            return result;
        }
    }
}
