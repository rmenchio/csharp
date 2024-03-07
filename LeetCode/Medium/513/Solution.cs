namespace LeetCode.Medium._513
{
    public class Solution
    {
        public int FindBottomLeftValue(TreeNode root)
        {
            var valor = 0;

            while(root is not null)
            {
                valor = root.val;
                FindBottomLeftValue(root.left);
                FindBottomLeftValue(root.right);
            }

            return valor;
        }

        private int Altura(TreeNode root)
        {
            if (root == null)
                return -1;
            else
            {
                int he = Altura(root.left);
                int hd = Altura(root.right);

                return he > hd ? he + 1 : hd + 1;
            }
        }
    }
}   