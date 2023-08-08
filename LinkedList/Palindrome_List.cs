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
    public bool IsPalindrome(ListNode head) {
      if(head==null || head.next ==null)
        return true;

        ListNode fast, slow;
        fast=slow=head;

        while(fast!=null && fast.next!=null)
        {

            fast=fast.next.next;
            slow=slow.next;
        }
        ListNode rhead=ReverseList(slow);

        ListNode temp=head;
        while(temp!=null && rhead!=null)
        {
            if(temp.val!=rhead.val)
            return false;

            temp=temp.next;
            rhead=rhead.next;
        }  
        return true;
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
