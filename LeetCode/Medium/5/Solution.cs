namespace LeetCode.Medium._5
{
    public class Solution
    {
        public string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) return "";

            int start = 0, maxLength = 1;

            for (int i = 0; i < s.Length; i++)
            {
                int len1 = ExpandAroundCenter(s, i, i); // Palíndromos de comprimento ímpar
                int len2 = ExpandAroundCenter(s, i, i + 1); // Palíndromos de comprimento par

                int len = Math.Max(len1, len2);
                if (len > maxLength)
                {
                    start = i - (len - 1) / 2;
                    maxLength = len;
                }
            }

            return s.Substring(start, maxLength);
        }

        private int ExpandAroundCenter(string s, int left, int right)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }
            return right - left - 1; // Tamanho do palíndromo
        }
    }
}