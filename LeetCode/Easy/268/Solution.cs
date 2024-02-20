namespace LeetCode.Easy._268
{
    public class Solution
    {
        public int MissingNumber(int[] nums)
        {
            Array.Sort(nums);

            if (nums[0] != 0)
                return 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] != nums[i + 1] - 1)
                    return nums[i] + 1;
            }

            return nums[^1] + 1;
        }
    }
}