namespace LeetCode.Easy._476
{
    public class Solution
    {
        public int FindComplement(int num)
        {
            string binario = "";

            while(num >= 1)
            {
                if (num % 2 == 0)
                    binario += "0";
                else
                    binario += "1";

                num /= 2;
            }

            var inicial = 1;
            var numeroFinal = 0;

            foreach(var carater in binario)
            {
                if (carater.Equals('0'))
                    numeroFinal += inicial;

                inicial *= 2;
            }

            return numeroFinal;
        }
    }
}