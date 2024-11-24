public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
    {
        ListNode head = null;
        ListNode tail = null;

        int x = 0;
        int y = 0;
        int carry = 0;

        while(l1!=null||l2!=null)
        {
            x = l1 != null ? l1.val:0;//判斷
            y = l2 != null ? l2.val:0;//判斷

            int sum = x+y+carry;//總和

            if(head==null)
            {
                head = new ListNode(sum%10);
                tail = head;//附值
            }
            else
            {
                tail.next = new ListNode(sum%10);
                tail = tail.next;//進位
            }

            carry = sum/10;
            //數組中丟進來的數字
            if(l1!=null)
            {
                l1=l1.next;
            }
            if(l2!=null)
            {
                l2 = l2.next;
            }
        }

        if(carry>0)
        {
            tail.next = new ListNode(carry);
        }
        return head;

    }
}
