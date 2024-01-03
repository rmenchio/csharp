namespace LeetCode.Easy._26
{
	public class Solution
	{
        int qntUnico = 0;
        List<int> numerosUnicos = new();

        public int RemoveDuplicates(int[] nums)
        {
            int contador = 0;

            for (int j = 0; j < nums.Length; j = j)
            {
                int num = nums[j];

                if (!numerosUnicos.Contains(num))
                {
                    qntUnico++;
                    numerosUnicos.Add(num);
                    j++;
                }
                else
                {
                    for (int i = j; i < nums.Length - 1; i++)
                    {
                        nums[i] = nums[i + 1];
                    }
                    
                    nums[nums.Length - 1] = num;
                }

                contador++;

                if (contador == nums.Length)
                    break;
            }
            
            return qntUnico;
        }
    }
}