namespace LeetCode.Easy._14
{
    public class Solutiontwo
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return "";

            int minLen = strs.Min(s => s.Length);

            for (int count = 0; count < minLen; count++) {
                char currentChar = strs[0][count];

                for (int i = 1; i < strs.Length; i++) {
                    if (strs[i][count] != currentChar)
                        return strs[0].Substring(0, count);
                }
            }

            return strs[0].Substring(0, minLen);
        }
    }
}
