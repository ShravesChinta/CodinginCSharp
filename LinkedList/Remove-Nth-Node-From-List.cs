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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
      
      ListNode slow, fast;
      ListNode temp_head=new ListNode(0);
      temp_head.next=head;
      slow=temp_head;
      fast=temp_head;
      for(int i=0;i<n;i++)
      {          
          fast=fast.next;
      }
      while(fast!=null && fast.next!=null)
      {
          fast=fast.next;
          slow=slow.next;
      }
      slow.next=slow.next.next;
      return temp_head.next;

    }
}
