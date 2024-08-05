namespace LeetCode.Easy._222
{
    public class Solution
    {
        public int CountNodes(TreeNode root)
        {
            var tamanho = 0;

            if (root is null)
                return 0;

            tamanho++;

            var esquerda = CountNodes(root.left);
            var direita = CountNodes(root.right);

            return tamanho + esquerda + direita;
        }
    }
}