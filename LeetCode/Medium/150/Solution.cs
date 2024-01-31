namespace LeetCode.Medium._150
{
    public class Solution
    {
        public int EvalRPN(string[] tokens)
        {
            Stack<int> pilhaTokens = new();

            for(int i = 0; i < tokens.Length; i++)
            {
                string valor = tokens[i];

                if (!EhOperacao(valor))
                    pilhaTokens.Push(int.Parse(valor));
                else
                {
                    var val2 = pilhaTokens.Pop();
                    var val1 = pilhaTokens.Pop();

                    pilhaTokens.Push(Operar(val1, val2, valor));
                }

            }

            return pilhaTokens.Peek();
        }

        private bool EhOperacao(string valor) => valor switch
        {
            var val when new[] { "*", "+", "-", "/" }.Contains(val) => true,
            _ => false
        };

        private int Operar(int val1, int val2, string op) => op switch
        {
            "*" => val1 * val2,
            "/" => val1 / val2,
            "+" => val1 + val2,
            "-" => val1 - val2,
            _ => throw new NotImplementedException()
        };
    }
}