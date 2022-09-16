namespace _283._Move_Zeroes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            var nums = new int[] { 0, 1, 0, 3,0,0, 12 };
            solution.MoveZeroes(nums);
            foreach (var el in nums)
            {
                Console.WriteLine(el);
            }
        }
    }

    public class Solution
    {
        //Input: nums = [0,1,0,3,12]

        public void MoveZeroes(int[] nums)
        {
            int i = nums.Length - 1;
            int j = nums.Length - 1;
            while (j >= 0)
            {
                if (nums[j] == 0)
                {
                    int k = nums[i];
                    int t = 0;
                    if (i > 0)
                    {
                        t = nums[i - 1];

                    }
                    nums[i] = nums[j];
                    int memI = i;
                   
                    while (i != j)
                    {

                        i--;
                        nums[i] = k;
                        k = t;
                        if (i > 0)
                        {
                            t = nums[i - 1];

                        }
                    }
                    i = memI;
                }
                j--;

            }
        }
    }
}