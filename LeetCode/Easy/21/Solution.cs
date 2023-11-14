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
            if (list1 == null)
                return list2;

            else if (list2 == null)
                return list1;

            ListNode novaLista = InicializandoNovaLista(ref list1, ref list2);
            ListNode cabeca = novaLista;

            while (list1 != null && list2 != null)
            {
                if(novaLista.val <= list1.val && list1.val <= list2.val)
                {
                    novaLista.next = list1;
                    list1 = list1.next;
                }

                else if (novaLista.val <= list2.val && list2.val <= list1.val)
                {
                    novaLista.next = list2;
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

        private static ListNode InicializandoNovaLista(ref ListNode list1, ref ListNode list2)
        {
            ListNode novaLista = new();

            if (list1.val <= list2.val)
            {
                novaLista.val = list1.val;
                list1 = list1.next;
            }
            else
            {
                novaLista.val = list2.val;
                list2 = list2.next;
                
            }

            return novaLista;
        }
    }
}