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

            while(l1 != null && l2 != null)
            {
                var n1 = l1.val;
                var n2 = l2.val;

                var n3 = n1 + n2;

                if(n3 >= 10)
                {
                    atual.val = n3 + emprestimo - 10;

                    if (l1.next != null || l2.next != null)
                        atual.next = new();

                    atual = atual.next;

                    emprestimo = 1;
                }
                else
                {
                    if(n3 + emprestimo >= 10)
                    {
                        atual.val = n3 + emprestimo - 10;

                        if(l1.next != null || l2.next != null)
                            atual.next = new();

                        atual = atual.next;
                        emprestimo = 1;
                    }
                    else
                    {
                        atual.val = n3 + emprestimo;

                        if (l1.next != null || l2.next != null)
                            atual.next = new();

                        atual = atual.next;
                        emprestimo = 0;
                    }
                }
                l1 = l1.next;
                l2 = l2.next;
            }

            if(l1 != null)
            {
                while(l1 != null)
                {
                    var n3 = l1.val;

                    if (n3 >= 10)
                    {
                        atual.val = n3 + emprestimo - 10;

                        if (l1.next != null)
                            atual.next = new();

                        atual = atual.next;

                        emprestimo = 1;
                    }
                    else
                    {
                        if (n3 + emprestimo >= 10)
                        {
                            atual.val = n3 + emprestimo - 10;

                            if (l1.next != null)
                                atual.next = new();

                            atual = atual.next;
                            emprestimo = 1;
                        }
                        else
                        {
                            atual.val = n3 + emprestimo;

                            if (l1.next != null)
                                atual.next = new();

                            atual = atual.next;
                            emprestimo = 0;
                        }
                    }
                    l1 = l1.next;
                }
            }

            if (l2 != null)
            {
                while (l2 != null)
                {
                    var n3 = l2.val;

                    if (n3 >= 10)
                    {
                        atual.val = n3 + emprestimo - 10;

                        if (l2.next != null)
                            atual.next = new();

                        atual = atual.next;

                        emprestimo = 1;
                    }
                    else
                    {
                        if (n3 + emprestimo >= 10)
                        {
                            atual.val = n3 + emprestimo - 10;

                            if (l2.next != null)
                                atual.next = new();

                            atual = atual.next;
                            emprestimo = 1;
                        }
                        else
                        {
                            atual.val = n3 + emprestimo;

                            if (l2.next != null)
                                atual.next = new();

                            atual = atual.next;
                            emprestimo = 0;
                        }
                    }
                    l2 = l2.next;
                }
            }

            if(emprestimo == 1)
            {
                atual = primeiro;

                while (atual.next != null)
                {
                    atual = atual.next;
                }
                atual.next = new();

                atual.next.val = 1;
            }

            return primeiro;
        }
    }
}