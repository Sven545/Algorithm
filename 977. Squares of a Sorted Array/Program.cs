namespace _977._Squares_of_a_Sorted_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            var result = solution.SortedSquares(new int[] { -4, -1, 0, 3, 10 });
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class Solution
    {
        public int[] SortedSquares(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = (int)Math.Pow(nums[i], 2);
            }
            var result = FastSort(nums);
            return result;
        }
        public int[] FastSort(int[] nums)
        {
            if (nums.Length < 2)
            {
                return nums;
            }
            var suppurt = nums[0];
            var less = nums.Where(n => n < suppurt);
            var more = nums.Where(n => n > suppurt);
            var current = nums.Where(n => n == suppurt);
            var sortedMore = FastSort(more.ToArray());
            var sortedLess = FastSort(less.ToArray());
            var first = sortedLess.Concat(current);
            var result = first.Concat(sortedMore).ToArray();
            return result;
        }
    }
}