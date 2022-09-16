using System.Collections;

namespace _3._Longest_Substring_Without_Repeating_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.LengthOfLongestSubstring("pwwek"));//abcabcbb
        }
    }

    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            int i = 0, j = 0;
            Hashtable ht = new Hashtable();
            int maxCount = 0;
            while (i < s.Length)
            {
                if (!ht.ContainsKey(s[i]))
                {

                    if (ht.Count == maxCount)
                    {
                        maxCount++;
                    }

                    ht.Add(s[i], i);
                    i++;
                }
                else
                {
                    while (ht.ContainsKey(s[i]))
                    {
                        ht.Remove(s[j]);
                        j++;
                    }
                    ht.Add(s[i],i);
                    i++;
                }

            }
            return maxCount;
        }
    }
}