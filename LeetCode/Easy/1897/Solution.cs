namespace LeetCode.Easy._1897
{
    public class Solution
    {
        public bool MakeEqual(string[] words)
        {
            var lista = words.ToList();

            var qntStrings = lista.Count;
            var qntCaracteres = lista.Sum(p => p.Length);
            var mediaCaracteres = qntCaracteres / qntStrings;
            var stringSerializada = string.Join("", words);

            if (qntCaracteres % qntStrings != 0)
                return false;

            if (qntStrings == 1)
                return true;

            Dictionary<char, int> mapaDosCaracteres = new();

            foreach(var a in stringSerializada)
            {
                if(!mapaDosCaracteres.Keys.ToList().Contains(a))
                {
                    mapaDosCaracteres.Add(a, 1);
                }
                else
                {
                    mapaDosCaracteres[a]++;
                }
            }

            if ((mapaDosCaracteres.Values.All(v => v > 1)
                && mapaDosCaracteres.Values.ToList().Aggregate(CalcularMDC) > 1) || mapaDosCaracteres.Keys.Count == 1)
                return true;

            return false;
        }

        static int CalcularMDC(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}