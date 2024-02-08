namespace LeetCode.Medium._1291
{
    public class Solution
    {
        public IList<int> SequentialDigits(int low, int high)
        {
            string numeros = "123456789";

            int tamanhoLow = low.ToString().Length;
            int tamanhoHigh = high.ToString().Length;

            List<int> tamanhosValidos = Enumerable.Range(tamanhoLow, tamanhoHigh).ToList();
            List<int> listaNumeros = new();

            foreach (int tamanho in tamanhosValidos)
            {
                int indice = 0;

                while (indice <= numeros.Length - tamanho)
                {
                    if (int.TryParse(numeros.AsSpan(indice, tamanho), out int numero) && numero <= high && numero >= low)
                        listaNumeros.Add(numero);
                    indice++;
                }
            }

            return listaNumeros;
        }
    }
}