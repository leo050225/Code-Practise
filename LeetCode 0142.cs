/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public ListNode DetectCycle(ListNode head) 
    {
        ListNode fast = head,slow = head,meet = null;

        while(fast!=null&&fast.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;

            if(slow == fast)
            {
                meet = fast;
                break;
            }
        }

        if(meet==null)return null;

        ListNode node1 = head, node2 = meet;


        while(node1 != node2)
        {
            node1 = node1.next;
            node2 = node2.next;
        }
        return node1;
    }
}
