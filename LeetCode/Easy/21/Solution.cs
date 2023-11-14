namespace LeetCode.Easy._21
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
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode novaLista = null;
            ListNode cabeca = novaLista;

            if (list1 == null)
                return list2;

            if (list2 == null)
                return list1;

            while (list1 != null && list2 != null)
            {
                if(novaLista == null)
                {
                    var numeroUm = list1.val;
                    var numeroDois = list2.val;

                    if (numeroUm <= numeroDois)
                    {
                        novaLista = new ListNode(numeroUm);
                        list1 = list1.next;
                    }
                    else
                    {
                        novaLista = new ListNode(numeroDois);
                        list2 = list2.next;
                    }
                    cabeca = novaLista;
                    continue;
                }

                var numeroAtual = novaLista.val;
                var numeroUmAtual = list1.val;
                var numeroDoisAtual = list2.val;

                if(numeroAtual <= numeroUmAtual && numeroUmAtual <= numeroDoisAtual)
                {
                    novaLista.next = new ListNode(numeroUmAtual);
                    list1 = list1.next;
                }

                else if (numeroAtual <= numeroDoisAtual && numeroDoisAtual <= numeroUmAtual)
                {
                    novaLista.next = new ListNode(numeroDoisAtual);
                    list2 = list2.next;
                }

                novaLista = novaLista.next;
            }

            if (list1 == null && list2 != null)
                novaLista.next = list2;
            else if(list2 == null && list1 != null)
                novaLista.next = list1;

            return cabeca;
        }
    }
}