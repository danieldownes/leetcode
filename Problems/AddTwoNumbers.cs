namespace Problems;

public static class AddTwoNumbers
{
    public static ListNode WithCarryMethod(ListNode l1, ListNode l2)
    {
        bool carry = false;
        ListNode ln = new ListNode();
        ListNode lnOut = ln;
        int p = 0;
        while (l1 != null || l2 != null || carry == true)
        {
            if (p > 0)
            {
                ln.next = new ListNode();
                ln = ln.next;
            }
            if (l1 != null)
                ln.val += l1.val;

            if (l2 != null)
                ln.val += l2.val;

            if (carry == true)
                ln.val++;

            if (ln.val > 9)
            {
                carry = true;
                ln.val -= 10;
            }
            else
                carry = false;

            if (l1 != null)
                l1 = l1.next;
            if (l2 != null)
                l2 = l2.next;

            p++;
        }

        return lnOut;

    }
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}