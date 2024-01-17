namespace LeetCode.Easy._1207
{
    public class Solution
    {
        public bool UniqueOccurrences(int[] arr)
        {
            Dictionary<int, int> dicionario = new Dictionary<int, int>();

            foreach (int valor in arr)
            {
                if (dicionario.ContainsKey(valor))
                {
                    dicionario[valor]++;
                }
                else
                {
                    dicionario.Add(valor, 1);
                }
            }

            return dicionario.Count == dicionario.Values.Distinct().Count();
        }
    }
}
