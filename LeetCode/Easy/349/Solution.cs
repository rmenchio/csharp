namespace LeetCode.Easy._349
{
	public class Solution
	{
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            HashSet<int> hash1 = new(nums1);
            HashSet<int> hash2 = new(nums2);

            List<int> lista1 = hash1.ToList();
            List<int> lista2 = hash2.ToList();

            int tamanhoMenor = lista1.Count >= lista2.Count ? lista2.Count : lista1.Count;

            if (lista1.Count == tamanhoMenor)
                return BuscarInterseccao(lista2, lista1).ToArray();
            else
                return BuscarInterseccao(lista1, lista2).ToArray();
        }

        private static List<int> BuscarInterseccao(List<int> maior, List<int> menor)
        {
            List<int> resultado = new();

            for(int i = 0; i < menor.Count; i++)
            {
                int valorAtual = menor[i];

                for(int j = 0; j < maior.Count; j++)
                {
                    int valorOutra = maior[j];

                    if(valorAtual == valorOutra)
                    {
                        resultado.Add(valorAtual);
                        break;
                    }
                }
            }

            return resultado;
        }
    }
}