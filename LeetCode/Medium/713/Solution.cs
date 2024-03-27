namespace LeetCode.Medium._713
{
    public class Solution
    {
        public int NumSubarrayProductLessThanK(int[] nums, int k)
        {
            int numeroSubArrays = 0;

            int posicaoInicial = 0;

            int i = 1;

            int multiplicacao = nums[posicaoInicial];

            while (posicaoInicial < nums.Length)
            {
                if (multiplicacao < k)
                {
                    numeroSubArrays++;

                    if (i < nums.Length)
                    {
                        multiplicacao *= nums[i];
                        i++;
                    }
                    else
                    {
                        multiplicacao = k;
                    }
                }
                else
                {
                    posicaoInicial++;

                    if (posicaoInicial >= nums.Length)
                        break;

                    multiplicacao = nums[posicaoInicial];

                    i = posicaoInicial + 1;
                }
            }

            return numeroSubArrays;
        }
    }
}