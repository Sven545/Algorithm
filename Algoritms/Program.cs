namespace Algoritms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.LengthOfLongestSubstring("aab"));
        }
    }

    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (!string.IsNullOrEmpty(s))
            {
                var chars = s.ToCharArray();
                int sequentalIndex = 0;
                int currentIndex = 0;
                var result = new List<char>();
                var lengths = new List<int>();
                var currentLenhth = 0;
                var que=new Queue<char>();
                
                while (currentIndex < chars.Length)
                {
                    char current = chars[currentIndex];
                    if (!result.Contains(current))
                    {
                        result.Add(current);
                        currentLenhth++;
                        currentIndex++;
                    }
                    else
                    {
                        currentLenhth = 0;
                        sequentalIndex++;
                        currentIndex = sequentalIndex;
                        result.Clear();


                    }
                    lengths.Add(currentLenhth);

                }
                if (lengths.Count==0)
                {
                    return currentLenhth;
                }
                else return lengths.Max();
            }
            else return 0;
            
        }
    }
}