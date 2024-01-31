using LeetCode.Medium._150;
class Program
{
    public static void Main(string[] args)
    {
        var teste = new Solution();

        Console.WriteLine(teste.EvalRPN(new[] { "2", "1", "+", "3", "*" }));
        Console.ReadLine();
    }
}