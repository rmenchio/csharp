/*
	Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

	An input string is valid if:

	Open brackets must be closed by the same type of brackets.
	Open brackets must be closed in the correct order.
	Every close bracket has a corresponding open bracket of the same type.
 */

namespace LeetCode.Easy._20
{
	public class Solution
	{
        public bool IsValid(string s)
        {
			var tamanho = s.Length;

            if (tamanho % 2 != 0)
				return false;

			for(int i = 0; i < tamanho - 1; i++)
			{
                var resolucao = CaracterFechamento(s[i]);
				var caracterSeguido = s[i + 1];
				var caracterSimetrico = s[tamanho - 1 - i];

				if (caracterSeguido.Equals(resolucao))
					i++;
				
                if (!(caracterSeguido.Equals(resolucao) || caracterSimetrico.Equals(resolucao)))
					return false;
			}

			return true;
        }

		private char CaracterFechamento(char ladoDireito) => ladoDireito switch
        {
			'(' => ')',
            '{' => '}',
            '[' => ']',
            ')' => '(',
            '}' => '{',
            ']' => '[',
            _ => throw new NotImplementedException(),
        };
    }
}