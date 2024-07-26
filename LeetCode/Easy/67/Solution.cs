namespace LeetCode.Easy._67
{
    public class Solution
    {
        public string AddBinary(string a, string b)
        {
            var tamanhoA = a.Length - 1;
            var tamanhoB = b.Length - 1;

            bool sobrou = false;

            Stack<string> resultado = new();

            while (tamanhoA >= 0 || tamanhoB >= 0)
            {
                int atualA = 0;
                int atualB = 0;

                if (tamanhoA >= 0)
                {
                    atualA = a[tamanhoA] - '0';
                    tamanhoA--;
                }

                if (tamanhoB >= 0)
                {
                    atualB = b[tamanhoB] - '0';
                    tamanhoB--;
                }

                var soma = atualA + atualB;

                if (sobrou)
                    soma++;

                switch (soma)
                {
                    case 0:
                        resultado.Push("0");
                        sobrou = false;
                        break;
                    case 1:
                        resultado.Push("1");
                        sobrou = false;
                        break;
                    case 2:
                        resultado.Push("0");
                        sobrou = true;
                        break;
                    case 3:
                        resultado.Push("1");
                        sobrou = true;
                        break;
                };

            }

            if (sobrou)
                resultado.Push("1");

            return string.Join("", resultado.ToArray());
        }
    }
}