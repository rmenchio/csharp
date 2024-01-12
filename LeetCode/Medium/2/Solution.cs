namespace LeetCode.Medium._2
{
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
	{
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode primeiro = new();
            ListNode atual = primeiro;
            int emprestimo = 0;

            while(l1 != null || l2 != null || emprestimo != 0)
            {
                var n1 = l1?.val ?? 0;
                var n2 = l2?.val ?? 0;

                var n3 = n1 + n2 + emprestimo;

                emprestimo = n3 / 10;

                atual.next = new ListNode(n3 % 10);
                atual = atual.next;

                l1 = l1?.next;
                l2 = l2?.next;
            }

            return primeiro;
        }
    }
}