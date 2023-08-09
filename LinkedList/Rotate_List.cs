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
    public ListNode RotateRight(ListNode head, int k) {
        if (head == null || k == 0)
            return head;

        int len = 1; // Start the length at 1 since there's at least one node
        ListNode temp = head;

        // Find the length of the linked list and the last node
        while (temp.next != null) {
            temp = temp.next;
            len++;
        }

        temp.next = head; // Connect the last node to the head to create a circular linked list

        k = k % len; // Reduce k to the effective rotations needed

        for (int i = 0; i < len - k; i++) {
            temp = temp.next;
        }

        ListNode newHead = temp.next;
        temp.next = null; // Break the circular connection

        return newHead;
    }
}
