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
    public ListNode RemoveNthFromEnd(ListNode head, int n) 
    {
        ListNode d = new ListNode();
        d.next = head;
        ListNode right = d;
        ListNode left = d;

        while(n-- != 0 && right != null)
        {
            right = right.next;
        }
        while(right.next != null)
        {
            right = right.next;
            left = left.next;
        }
        left.next = left.next.next;

        return d.next;
    }
}
