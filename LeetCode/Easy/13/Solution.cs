namespace LeetCode.Easy._13
{
    public class Solution
    {
        public int RomanToInt(string s)
        {
            var romanToInteger = new Dictionary<char, int>
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            var soma = 0;
            int anterior = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                int valor = romanToInteger[s[i]];

                if (valor < anterior)
                {
                    soma -= valor;
                }
                else
                {
                    soma += valor;
                }

                anterior = valor;
            }

            return soma;
        }
    }
}
