namespace LeetCode.Medium._1457
{
    public class Solution
    {
        public int PseudoPalindromicPaths(TreeNode raiz)
        {
            return ContarCaminhosPseudoPalindromo(raiz, 0);
        }

        private int ContarCaminhosPseudoPalindromo(TreeNode no, int contagem)
        {
            if (no == null)
            {
                return 0;
            }

            contagem ^= 1 << (no.val - 1);

            if (no.left == null && no.right == null)
            {
                // Check if the current path is pseudo-palindromic
                return (contagem & (contagem - 1)) == 0 ? 1 : 0;
            }

            int caminhosEsquerda = ContarCaminhosPseudoPalindromo(no.left, contagem);
            int caminhosDireita = ContarCaminhosPseudoPalindromo(no.right, contagem);

            return caminhosEsquerda + caminhosDireita;
        }
    }
}