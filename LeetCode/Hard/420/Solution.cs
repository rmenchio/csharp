namespace LeetCode.Hard._420
{
    public class Solution
    {
        public int StrongPasswordChecker(string password)
        {
            int steps = 0;

            int passwordLength = password.Length;

            if(passwordLength < 6)
            {
                steps += 6 - passwordLength;
            }

            if(passwordLength > 20)
            {
                steps += passwordLength - 20;
            }

            return 0;
        }
    }
}
