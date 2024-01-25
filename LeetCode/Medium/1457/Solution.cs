namespace LeetCode.Medium._1457
{
    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
        }
    }

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