namespace _344._Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var chars="Hello".ToCharArray();
            Solution solution = new Solution();
            solution.ReverseString(chars);
            Console.WriteLine(new String(chars));
        }
    }

    public class Solution
    {
        public void ReverseString(char[] s)
        {
            int i = 0;
            int j = s.Length-1;
            char k;
            while (i < j)
            {
                k = s[i];
                s[i] = s[j];
                s[j] = k;
                i++;
                j--;
            }
        }
    }
}