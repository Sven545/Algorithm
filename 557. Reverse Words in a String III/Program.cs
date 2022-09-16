namespace _557._Reverse_Words_in_a_String_III
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.ReverseWords("Let's take LeetCode contest"));
        }
    }

    public class Solution
    {
        public string ReverseWords(string s)
        {
            var words = s.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {

                var wordChars = words[i].ToCharArray();

                int j = 0;
                int k = wordChars.Length - 1;
                char t;

                while (j < k)
                {
                    t=wordChars[j];
                    wordChars[j] = wordChars[k];
                    wordChars[k] = t;
                    j++;
                    k--;
                }
                words[i]=new string(wordChars);
            }
            return string.Join(" ", words);
        }
    }
}