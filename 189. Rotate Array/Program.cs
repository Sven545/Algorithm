namespace _189._Rotate_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            var test = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            foreach (var item in test)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class Solution
    {
        public void Rotate(int[] nums, int k)
        {
            var rightPart = new int[k];
            var leftPart = new int[nums.Length - k];

            Array.Copy(nums, nums.Length - k, rightPart, 0, k);
            Array.Copy(nums, 0, leftPart, 0, nums.Length - k);
            var output = rightPart.Concat(leftPart).ToArray();
        }
    }
}