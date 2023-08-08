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
    public ListNode DetectCycle(ListNode head) {
        if(head==null)
        return head;

        ListNode slow, fast;
        slow=fast=head;
        bool flag=false;
        while(fast!=null && fast.next!=null)
        {
            slow=slow.next;
            fast=fast.next.next;

            if(slow==fast)
            {
                flag=true;
                break;
            }
        }
        if(!flag)
        return null;

        fast=head;
        while(fast!=slow)
        {
            fast=fast.next;
            slow=slow.next;
        }

        return slow;
    }
}
