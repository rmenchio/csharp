namespace LeetCode.Easy._100
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }   
    }

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