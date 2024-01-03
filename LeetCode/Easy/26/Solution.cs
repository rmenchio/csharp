namespace LeetCode.Easy._26
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
                return 0;

            int qntUnico = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    if(qntUnico != i)
                    {
                        nums[qntUnico] = nums[i];
                    }

                    qntUnico++;
                }
            }

            return qntUnico;
        }
    }
}