namespace LeetCode.Easy._35
{
    public class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {
            if (nums[^1] < target)
                return nums.Length;

            for (int i = 0; i < nums.Length; i++)
            {
                var numeroAtual = nums[i];

                if (numeroAtual >= target)
                    return i;
            }

            return 0;
        }
    }
}