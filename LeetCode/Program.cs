using LeetCode.Easy._100;
class Program
{
    public static void Main(string[] args)
    {
        var teste = new Solution();

        TreeNode p1 = new TreeNode(1, new TreeNode(2), new TreeNode(1));
        TreeNode p2 = new TreeNode(1, new TreeNode(1), new TreeNode(2));

        Console.WriteLine(teste.IsSameTree(p1, p2));
        Console.ReadLine();
    }
}