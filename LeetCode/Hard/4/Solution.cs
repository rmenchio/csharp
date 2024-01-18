namespace LeetCode.Hard._4
{
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            double mediana = 0.0;

            int[] nums3 = nums1.Concat(nums2).ToArray();

            Array.Sort(nums3);

            int tamanho = nums3.Length - 1;

            if (tamanho % 2 != 0)
            {
                mediana = (nums3[tamanho / 2] + nums3[(tamanho / 2) + 1]) / 2.0;
            }
            else
            {
                mediana = nums3[tamanho / 2] / 1.0;
            }

            return mediana;
        }
    }
}