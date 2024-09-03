namespace LeetCode.Easy._3110
{
    public class Solution
    {
        public int ScoreOfString(string s)
        {
            int soma = 0;

            for(int i = 0; i < s.Length - 1; i++)
            {
                soma += Math.Abs(s[i] - s[i + 1]);
            }

            return soma;
        }
    }
}