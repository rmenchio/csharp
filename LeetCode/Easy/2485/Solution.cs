namespace LeetCode.Easy._2485
{
    public class Solution
    {
        public int PivotInteger(int n)
        {
            var lista = Enumerable.Range(1, n).ToList();

            for(int i = 0; i < lista.Count; i++)
            {
                int soma = lista.GetRange(0, i + 1).Sum();
                int atual = lista.GetRange(i, lista.Count - i).Sum();

                if (soma == atual)
                    return lista[i];
            }

            return -1;
        }
    }
}