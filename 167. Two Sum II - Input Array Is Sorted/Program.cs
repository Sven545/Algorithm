namespace _167._Two_Sum_II___Input_Array_Is_Sorted
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            var result = solution.TwoSum(new int[] { 3, 24, 50, 79, 88, 150, 345 }, 200);
            foreach (var el in result)
            {
                Console.WriteLine(el);//[3,24,50,79,88,150,345]

            }
        }
    }

    public class Solution
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int upp = numbers.Length - 1;
            int less = 0;
            while (numbers[less] + numbers[upp]!=target)
            {
                if(numbers[less] + numbers[upp] > target)
                {
                    upp--;
                    continue;
                }
                if(numbers[less] + numbers[upp] < target)
                {
                    less++;
                }
            }
            return new int[] { less+1,upp+1 };
        }
    }
}