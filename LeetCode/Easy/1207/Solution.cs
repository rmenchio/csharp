namespace LeetCode.Easy._1207
{
    public class Solution
    {
        public bool UniqueOccurrences(int[] arr)
        {
            Dictionary<int, int> dicionario = new();

            for (int i = 0; i < arr.Length; i++)
            {
                int valor = arr[i];

                if(dicionario.ContainsKey(valor))
                {
                    dicionario[valor]++;
                }
                else
                {
                    dicionario.Add(valor, 1);
                }
            }

            if(dicionario.Values.ToList().Count() == dicionario.Values.Distinct().ToList().Count()) 
            {
                return true;
            }

            return false;
        }
    }
}
