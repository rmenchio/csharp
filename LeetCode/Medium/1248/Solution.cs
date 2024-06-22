namespace LeetCode.Medium._1248
{
    public class Solution
    {
        public int NumberOfSubarrays(int[] nums, int k)
        {
            int numeroSubArrays = 0;
            int n = nums.Length;
            int countOdd = 0;
            var prefixCounts = new Dictionary<int, int>();
            prefixCounts[0] = 1;

            int currentSum = 0;

            for (int i = 0; i < n; i++)
            {
                if (nums[i] % 2 != 0)
                {
                    countOdd++;
                }

                currentSum = countOdd;

                if (prefixCounts.ContainsKey(currentSum - k))
                {
                    numeroSubArrays += prefixCounts[currentSum - k];
                }

                if (!prefixCounts.ContainsKey(currentSum))
                {
                    prefixCounts[currentSum] = 0;
                }

                prefixCounts[currentSum]++;
            }

            return numeroSubArrays;
        }
    }
}