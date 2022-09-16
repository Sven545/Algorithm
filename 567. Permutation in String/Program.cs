namespace _567._Permutation_in_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.CheckInclusion("ab", "ab"));
        }
    }

    public class Solution
    {
        public bool CheckInclusion(string s1, string s2)
        {
            var rotstetS = Rotate(s1);
            if (rotstetS==s2)
            {
                return true;
            }
            bool result = true;
            int j = 0;

            while (j < s2.Length-1)
            {
                if (rotstetS[0] == s2[j])
                {
                    for (int i = 0; i < rotstetS.Length; i++)
                    {
                        if (rotstetS[i] != s2[j+i])
                        {
                            j=j+i;
                            result = false;
                            break;
                        }
                    }
                    if (result==true)
                    {
                        return true;

                    }
                }
                j++;
            }
            return false;
        }
        public string Rotate(string s)
        {
            var chars = s.ToCharArray();
            char k;
            int i = 0;
            int j = chars.Length - 1;

            while (i < j)
            {
                k = chars[i];
                chars[i] = chars[j];
                chars[j] = k;
                i++;
                j--;
            }
            return new string(chars);
        }
    }
}