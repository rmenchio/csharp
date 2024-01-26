namespace LeetCode.Easy._455
{
    public class Solution
    {
        public int FindContentChildren(int[] g, int[] s)
        {
            Array.Sort(g);
            Array.Sort(s);

            int filhosSatisfeitos = 0;

            int i = 0;
            int j = 0;

            while (i < g.Length && j < s.Length)
            {
                if (g[i] <= s[j])
                {
                    filhosSatisfeitos++;
                    i++;
                }

                j++;
            }

            return filhosSatisfeitos;
        }
    }
}