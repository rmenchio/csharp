namespace LeetCode.Easy._1002
{
    public class Solution
    {
        public IList<string> CommonChars(string[] words)
        {
            List<string> caracteres = new();

            var primeiraPalavra = words[0];
            var listaPalavras = words.ToList();
            listaPalavras.Remove(primeiraPalavra);

            foreach (char letra in primeiraPalavra)
            {
                bool contem = true;

                for (int i = 0; i < listaPalavras.Count; i++)
                {
                    if (!listaPalavras[i].Contains(letra))
                    {
                        contem = false;
                        break;
                    }

                    int index = listaPalavras[i].IndexOf(letra);

                    if (index != -1)
                    {
                        listaPalavras[i] = listaPalavras[i].Remove(index, 1);
                    }
                }

                if (contem)
                    caracteres.Add(letra.ToString());
            }

            return caracteres;
        }
    }
}