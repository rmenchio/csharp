namespace LeetCode.Easy._100
{
    public class Solution
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p != null && q != null)
            {
                if (p.val != q.val)
                    return false;

                var esquerda = IsSameTree(p.left, q.left);
                var direita = IsSameTree(p.right, q.right);

                return esquerda && direita;
            }
            else if (p == null && q != null || p != null && q == null)
                return false;

            return true;
        }
    }
}