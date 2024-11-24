/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode RemoveElements(ListNode head, int val) 
    {
        ListNode dummyHead = new ListNode(0);
        dummyHead.next = head;

        ListNode temp = dummyHead;

        while(temp.next != null)
        {
            if(temp.next.val == val)
            {
                temp.next = temp.next.next;
            }
            else
            {
                temp = temp.next;
            }
        }

        return dummyHead.next;
    }
}
