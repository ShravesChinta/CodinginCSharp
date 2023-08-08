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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode l3=new ListNode(0);
        ListNode temp_head=l3;
        int carry=0;
        int last_digit=0;
        int sum=0;

        while(l1!=null || l2!=null)
        {
            int val1=l1!=null ? l1.val: 0;
            int val2=l2!=null ? l2.val: 0;

            sum=val1+val2+carry;
            carry=sum/10;
            last_digit=sum%10;

            l3.next=new ListNode(last_digit);

            if(l1!=null)
            l1=l1.next;
            if(l2!=null)
            l2=l2.next;
            l3=l3.next;

        }

        if(carry>0)
        {
            l3.next=new ListNode(carry);
        }

        return temp_head.next;
    }
}
