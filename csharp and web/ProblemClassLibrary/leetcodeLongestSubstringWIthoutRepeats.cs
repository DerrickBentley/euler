using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemClassLibrary
{
    public class leetcodeLongestSubstringWIthoutRepeats
    {

        public string findSubstring(String a)
        {
            string result = "";
            for (int i = 0; i < a.Length; i++)
            {
                string temp = "";
                for (int j = i; j < a.Length && temp.IndexOf(a[j]) < 0; j++)
                {
                    temp += a[j];
                }
                if (temp.Length > result.Length)
                {
                    result = temp;
                }
            }
            return result;
        }
    }
}
