namespace LeetCode.Medium._2966
{
    public class Solution
    {
        public int[][] DivideArray(int[] nums, int k)
        {
            Array.Sort(nums);

            List<int[]> resultado = new();

            for(int i = 0; i < nums.Length - 2; i += 3)
            {
                if (Math.Abs(nums[i] - nums[i + 1]) <= k && Math.Abs(nums[i] - nums[i + 2]) <= k)
                    resultado.Add(new int[] { nums[i], nums[i + 1], nums[i + 2] });
                else
                    return new int[][] {};
            }

            return resultado.ToArray();
        }
    }
}