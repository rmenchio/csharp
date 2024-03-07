
using LeetCode.Easy._876;
class Program
{
    public static void Main(string[] args)
    {
        var teste = new Solution();

        ListNode p1 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));

        Console.WriteLine(teste.MiddleNode(p1));
        Console.ReadLine();
    }
}