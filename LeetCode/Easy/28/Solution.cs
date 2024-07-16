namespace LeetCode.Easy._28
{
    public class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            int tamanhoMaximoNeedle = needle.Length;
            int tamanhoMaximoHaystack = haystack.Length;
            int contador = 1;
            var primeiroCaracter = needle[0];

            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i].Equals(primeiroCaracter) && tamanhoMaximoHaystack - i >= tamanhoMaximoNeedle)
                {
                    if (needle.Length == 1)
                        return i;

                    for(int j = 1; j < needle.Length; j++)
                    {
                        if (!haystack[i + j].Equals(needle[j]))
                        {
                            contador = 1;
                            break;
                        }
                        else
                        {
                            contador++;
                        }

                        if (contador == tamanhoMaximoNeedle)
                            return i;
                    }
                }
            }

            return -1;
        }
    }
}