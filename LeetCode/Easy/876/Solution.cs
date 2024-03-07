namespace LeetCode.Easy._876
{
    public class Solution
    {
        public ListNode MiddleNode(ListNode head)
        {
            double tamanho = 0;

            ListNode aux = head;
            ListNode retorno = head;

            while (aux != null)
            {
                tamanho++;
                aux = aux.next;
            }

            tamanho = tamanho % 2 == 0 ? (tamanho/2) + 1 : Math.Ceiling(tamanho / 2);

            for(int i = 1; i < tamanho; i++)
            {
                retorno = retorno.next;
            }

            return retorno;
        }
    }
}