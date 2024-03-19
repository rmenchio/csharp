
using LeetCode.Medium._1171;
class Program
{
    public static void Main(string[] args)
    {
        var teste = new Solution();

        ListNode head = new(1, new(2, new(-3, new(3, new(1)))));

        Console.WriteLine(teste.RemoveZeroSumSublists(head));
        Console.ReadLine();
    }
}