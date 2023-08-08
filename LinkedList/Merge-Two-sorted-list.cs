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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode head=new ListNode(0);
        ListNode ref_head=head;

        if(list1==null && list2==null)
        return list1;

        if(list1==null)
        return list2;

        if(list2==null)
        return list1;

        while(list1!=null && list2!=null)
        {
            if(list1.val>list2.val)
            {
                head.next=new ListNode(list2.val);
                list2=list2.next;
            }
            else
            {
                head.next=new ListNode(list1.val);
                list1=list1.next;
            }
            head=head.next;
        }

        while(list1!=null)
        {
            head.next=new ListNode(list1.val);
            list1=list1.next;
            head=head.next;
        }

        while(list2!=null)
        {
            head.next=new ListNode(list2.val);
            list2=list2.next;
            head=head.next;
        }

        return ref_head.next;
    }
}
