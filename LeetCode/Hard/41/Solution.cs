namespace LeetCode.Hard._41
{
    public class Solution
    {
        public int FirstMissingPositive(int[] nums)
        {
            nums = nums
                .Where(x => x > 0)
                .Distinct()
                .OrderBy(x => x)
                .ToArray();

            if (nums.Length == 0 || nums[0] != 1)
                return 1;

            for(int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] + 1 != nums[i + 1])
                    return nums[i] + 1;
            }

            return nums.Last() + 1;
        }
    }
}