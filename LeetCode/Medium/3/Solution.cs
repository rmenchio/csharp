namespace LeetCode.Medium._3
{
    public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        if (string.IsNullOrEmpty(s))
            return 0;

        int n = s.Length;
        HashSet<char> charSet = new HashSet<char>();
        int maiorTamanho = 0, i = 0, j = 0;

        while (i < n && j < n)
        {
            if (!charSet.Contains(s[j]))
            {
                charSet.Add(s[j++]);
                maiorTamanho = Math.Max(maiorTamanho, j - i);
            }
            else
            {
                charSet.Remove(s[i++]);
            }
        }

        return maiorTamanho;
    }
}

}
