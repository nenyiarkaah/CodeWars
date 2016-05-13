using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsecutiveStrings
{
    public class LongestConsecutives
    {
        public static String LongestConsec(string[] strarr, int k)
        {
            // your code
            if (!strarr.Any())
            {
                return "";
            }

            if (k > strarr.Length)
            {
                return "";
            }
            string result = "";
            for (int i = 0; i < strarr.Length; i++)
            {
                string partial = string.Join("", strarr.Skip(i).Take(k).ToList());
                if (partial.Length > result.Length)
                {
                    result = partial;
                }
            }

            return result;
        }

    }
}
