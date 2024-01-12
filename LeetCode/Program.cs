using LeetCode.Medium._2;
class Program
{
    public static void Main(string[] args)
    {
        var teste = new Solution();

        ListNode l1 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))))))));
        ListNode l2 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))));

        Console.WriteLine(teste.AddTwoNumbers(l1, l2));
        Console.ReadLine();
    }
}