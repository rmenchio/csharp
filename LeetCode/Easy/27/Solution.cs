namespace LeetCode.Easy._27
{
    // nums = [3,2,2,3], val = 3
    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            int k = 0; // Initialize a variable to keep track of non-val elements
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[k] = nums[i]; // Move non-val element to the beginning of the array
                    k++; // Increment k
                }
            }
            return k;
        }
    }
}