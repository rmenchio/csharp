using LeetCode.Easy._21;
class Program
{
    public static void Main(string[] args)
    {
        var teste = new Solution();

        var list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
        var list2 = new ListNode(1, new ListNode(3, new ListNode(4)));

        Console.WriteLine(teste.MergeTwoLists(list1, list2));
        Console.ReadLine();
    }
}