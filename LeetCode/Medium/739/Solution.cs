namespace LeetCode.Medium
{
    public class Solution
    {
        public int[] DailyTemperatures(int[] temperatures)
        {
            int quantidadeTemperaturas = temperatures.Length;
            int[] diasAntesDoDiaMaisQuente = new int[quantidadeTemperaturas];

            for(int i = 0; i < quantidadeTemperaturas; i++)
            {
                int contador = 1;

                for (int j = i + 1; j < quantidadeTemperaturas; j++)
                {
                    if (temperatures[j] > temperatures[i])
                    {
                        diasAntesDoDiaMaisQuente[i] = contador;
                        break;
                    }
                    else
                    {
                        contador++;
                    }
                }
            }

            return diasAntesDoDiaMaisQuente;
        }
    }
}