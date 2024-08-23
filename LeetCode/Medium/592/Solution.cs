namespace LeetCode.Medium._592
{
    public class Solution
    {
        public string FractionAddition(string expression)
        {
            string[] fracoes = expression.Split(new char[] { '+', '-' }, StringSplitOptions.RemoveEmptyEntries);
            char[] sinais = expression.Where(s => s.Equals('+') || s.Equals('-')).ToArray();

            bool primeiroSinalNegativo = sinais.Length == fracoes.Length;

            int parteCima = primeiroSinalNegativo ? -Convert.ToInt32(fracoes[0].Split("/")[0]) : Convert.ToInt32(fracoes[0].Split("/")[0]);

            int parteBaixo = Convert.ToInt32(fracoes[0].Split("/")[1]);

            int sinalAtual = primeiroSinalNegativo ? 1 : 0;

            SomandoFracoes(fracoes, sinais, ref parteCima, ref parteBaixo, ref sinalAtual);

            TornandoFracaoIrredutivel(ref parteCima, ref parteBaixo);

            return string.Concat(parteCima, "/", parteBaixo); ;
        }

        private static void SomandoFracoes(string[] fracoes, char[] sinais, ref int parteCima, ref int parteBaixo, ref int sinalAtual)
        {
            for (int i = 1; i < fracoes.Length; i++)
            {
                var fracaoSplitada = fracoes[i].Split("/");

                var numeroAtualCima = Convert.ToInt32(fracaoSplitada[0]);
                var numeroAtualBaixo = Convert.ToInt32(fracaoSplitada[1]);

                if (parteBaixo != numeroAtualBaixo)
                {
                    parteCima *= numeroAtualBaixo;
                    numeroAtualCima *= parteBaixo;

                    var baixoAux = parteBaixo;
                    parteBaixo *= numeroAtualBaixo;
                    numeroAtualBaixo *= baixoAux;
                }

                var sinal = sinais[sinalAtual];

                if (sinal == '+')
                    parteCima += numeroAtualCima;
                else
                    parteCima -= numeroAtualCima;

                sinalAtual++;
            }
        }

        private static void TornandoFracaoIrredutivel(ref int parteCima, ref int parteBaixo)
        {
            if (parteCima == 0)
                parteBaixo = 1;
            else
            {
                int[] mdc = { 2, 3, 5, 7 };
                int indiceMdcAtual = 0;

                while (indiceMdcAtual < 4 && parteBaixo != 1)
                {
                    int mdcAtual = mdc[indiceMdcAtual];

                    if (parteCima % mdcAtual == 0 && parteBaixo % mdcAtual == 0)
                    {
                        parteCima /= mdcAtual;
                        parteBaixo /= mdcAtual;
                    }
                    else
                    {
                        indiceMdcAtual++;
                    }
                }
            }
        }
    }
}