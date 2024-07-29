namespace LeetCode.Easy._69
{
    public class Solution
    {
        // OBSERVAÇÃO IMPORTANTE
        // You must not use any built-in exponent function or operator.
        // For example, do not use pow(x, 0.5) in c++ or x ** 0.5 in python.

        public int MySqrt(int x)
        {
            if (x == 0) return 0;
            int left = 1, right = x, result = 0;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (mid <= x / mid)
                {
                    left = mid + 1;
                    result = mid;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return result;
        }
    }
}