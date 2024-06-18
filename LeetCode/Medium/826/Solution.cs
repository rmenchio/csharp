namespace LeetCode.Medium._826
{
	public class Solution
	{
        public int MaxProfitAssignment(int[] difficulty, int[] profit, int[] worker)
        {

            int lucroTotal = 0;
            int qntTrabalhadores = worker.Length;
            int qntTrabalhos = difficulty.Length;

            for (int i = 0; i < qntTrabalhadores; i++)
            {
                int trabalhadorAtual = worker[i];

                int maiorLucro = 0;

                for(int j = 0; j < qntTrabalhos; j++)
                {
                    int trabalhoAtual = difficulty[j];
                    int lucroAtual = profit[j];

                    if (trabalhoAtual <= trabalhadorAtual && lucroAtual > maiorLucro)
                        maiorLucro = lucroAtual;
                }

                lucroTotal += maiorLucro;
            }
            
            return lucroTotal;
        }
    }
}