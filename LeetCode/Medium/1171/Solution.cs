namespace LeetCode.Medium._1171
{
    // Ainda não finalizei
    public class Solution
    {
        public ListNode RemoveZeroSumSublists(ListNode head)
        {
            var refInicio = head;
            List<int> lista = new();

            while (refInicio != null)
            {
                lista.Add(refInicio.val);
                refInicio = refInicio.next;
            }

            return new();
        }
    }
}