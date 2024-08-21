namespace LeetCode.Easy
{
    public class Solution
    {
        public int MaxDepth(TreeNode root)
        {
            if (root is null)
                return 0;

            int profundidadeDireita = MaxDepth(root.right);
            int profundidadeEsquerda = MaxDepth(root.left);

            return profundidadeDireita > profundidadeEsquerda ? profundidadeDireita + 1 : profundidadeEsquerda + 1;
        }
    }
}