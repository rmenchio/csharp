namespace LeetCode.Easy._58
{
    public class Solution
    {
        public int LengthOfLastWord(string s)
        {
            return string.Join("", s.TrimEnd().Reverse()).Split(" ")[0].Length;
        }
    }
}