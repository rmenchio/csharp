namespace LeetCode.Easy._83
{
    public class Solution
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            var aux = head;

            while(aux != null)
            {
                var proximo = aux?.next;

                while (proximo != null && aux.val == proximo.val)
                {
                    aux.next = proximo.next;
                    proximo = aux.next;
                }

                aux = aux.next;
            }

            return head;
        }
    }
}