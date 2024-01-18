namespace LeetCode.Easy._70
{
    public class Solution
    {
        public int ClimbStairs(int n)
        {
            int numeroAnterior = 0;
            int numeroAtual = 1;
            int possibilidades = 0;

            for(int i = 0; i < n; i++)
            {
                possibilidades = numeroAnterior + numeroAtual;
                numeroAnterior = numeroAtual;
                numeroAtual = possibilidades;
            }

            return possibilidades;
        }
    }
}