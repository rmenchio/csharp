
using LeetCode.Medium._513;
class Program
{
    public static void Main(string[] args)
    {
        var teste = new Solution();

        TreeNode p1 = new TreeNode(2, new TreeNode(1), new TreeNode(3));

        Console.WriteLine(teste.FindBottomLeftValue(p1));
        Console.ReadLine();
    }
}