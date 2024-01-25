using LeetCode.Medium._1457;
class Program
{
    public static void Main(string[] args)
    {
        var teste = new Solution();

        TreeNode root = new(2,new(3, new(3), new(1)), new(1, null, new(1)));

        Console.WriteLine(teste.PseudoPalindromicPaths(root));
        Console.ReadLine();
    }
}