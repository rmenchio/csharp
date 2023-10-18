/*
 * Given an integer x, return true if x is a palindrome, and false otherwise.
 */

namespace LeetCode.Easy._9
{
	public class Solution
	{
        public bool IsPalindrome(int x)
        {
            char[] x_list = x.ToString().ToArray();

            Array.Reverse(x_list);

            string x_reverse_string = new string(x_list);
            string x_string = x.ToString();

            return x_string.Equals(x_reverse_string);
        }
    }
}