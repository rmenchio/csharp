
using LeetCode.Medium._826;
class Program
{
    public static void Main(string[] args)
    {
        var teste = new Solution();
        var difficulty = new[] { 2, 4, 6, 8, 10 };
        var profit = new[] { 10, 20, 30, 40, 50 };
        var worker = new[] { 4, 5, 6, 7 };

        Console.WriteLine(teste.MaxProfitAssignment(difficulty, profit, worker));
        Console.ReadLine();
    }
}