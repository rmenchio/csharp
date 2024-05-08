namespace LeetCode.Easy._506
{
    public class Solution
    {
        public string[] FindRelativeRanks(int[] score)
        {
            var listaOrdenada = new List<int>(score);

            listaOrdenada.Sort();
            listaOrdenada.Reverse();

            Dictionary<int, string> relacao = new();

            int posicao = 1;


            foreach (int i in listaOrdenada)
            {
                relacao.Add(i, MapeandoPosicao(posicao));
                posicao++;
            }

            List<string> listaFinal = new();

            foreach(var i in score)
            {
                relacao.TryGetValue(i, out string value);

                listaFinal.Add(value);
            }

            return listaFinal.ToArray();
            
        }

        private static string MapeandoPosicao(int posicao) => posicao switch
        {
            1 => "Gold Medal",
            2 => "Silver Medal",
            3 => "Bronze Medal",
            _ => posicao.ToString()

        };
    }
}