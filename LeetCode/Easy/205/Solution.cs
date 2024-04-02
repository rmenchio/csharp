namespace LeetCode.Easy._205
{
	public class Solution
	{
        public bool IsIsomorphic(string s, string t)
        {
            Dictionary<string, string> mapeamento = new();

            for(int i = 0; i< s.Length; i++)
            {
                var letraS = s[i].ToString();
                var letraT = t[i].ToString();

                if (mapeamento.ContainsKey(letraS))
                {
                    var valor = mapeamento[letraS];

                    if (!valor.Equals(letraT))
                        return false;
                }
                else
                {
                    if (mapeamento.ContainsValue(letraT))
                        return false;

                    mapeamento.Add(letraS, letraT);
                }
                    
            }

            return true;
        }
    }
}