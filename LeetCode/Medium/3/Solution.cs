namespace LeetCode.Medium._3
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;

            string palavraAtual = "";
            int maiorTamanho = 0;

            for (int j = 0; j < s.Length; j++)
            {
                int i = j;

                for (; i < s.Length; i++)
                {
                    if (!palavraAtual.Contains(s[i]))
                    {
                        palavraAtual += s[i];

                        maiorTamanho = palavraAtual.Length > maiorTamanho ? palavraAtual.Length : maiorTamanho;
                    }
                    else
                    {
                        maiorTamanho = palavraAtual.Length > maiorTamanho ? palavraAtual.Length : maiorTamanho;

                        palavraAtual = "";

                        break;
                    }

                }
            }

            return maiorTamanho;
        }
    }
}
