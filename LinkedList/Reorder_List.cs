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
    public void ReorderList(ListNode head) {
       if(head==null || head.next ==null)
        return;

        ListNode fast, slow;
        fast=slow=head;

        while(fast!=null && fast.next!=null)
        {

            fast=fast.next.next;
            slow=slow.next;
        }
        ListNode second=ReverseList(slow.next);
        slow.next=null;
        ListNode first=head;

        while(first!=null && second!=null)
        {
            ListNode temp1=first.next;
            ListNode temp2=second.next;

            first.next=second;
            second.next=temp1;

            first=temp1;
            second=temp2;
        }
    }

    public ListNode ReverseList(ListNode head) {
        ListNode curr=head;
        ListNode next=null, prev=null;

        if(head==null)
        return head;

        while(curr!=null)
        {
            next=curr.next;
            curr.next=prev;
            prev=curr;
            curr=next;

        }

        return prev;
    }


}
