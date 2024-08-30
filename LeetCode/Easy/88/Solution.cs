namespace LeetCode.Easy._88
{
    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int index1 = m - 1; // Último elemento válido em nums1
            int index2 = n - 1; // Último elemento em nums2
            int indexAtual = m + n - 1; // Última posição disponível em nums1

            while (index2 >= 0)
            {
                if (index1 >= 0 && nums1[index1] > nums2[index2])
                {
                    nums1[indexAtual] = nums1[index1];
                    index1--;
                }
                else
                {
                    nums1[indexAtual] = nums2[index2];
                    index2--;
                }
                indexAtual--;
            }
        }
    }
}