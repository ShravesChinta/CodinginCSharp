**
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
    public ListNode MergeKLists(ListNode[] lists) {
        PriorityQueue<int, int> pq=new PriorityQueue<int, int>();
        ListNode new_head=new ListNode(0);
        ListNode ref_head=new_head;

        foreach(ListNode list in lists)
        {
            ListNode temp=list;
            while(temp!=null)
            {
                pq.Enqueue(temp.val, temp.val);
                temp=temp.next;
            }
        }

        while(pq.Count>0)
        {
            new_head.next=new ListNode(pq.Dequeue());
            new_head=new_head.next;
        }

        return ref_head.next;
    }
}
