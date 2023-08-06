public class Solution {
    public int FindKthLargest(int[] nums, int k) {
       PriorityQueue<int, int> minHeap=new PriorityQueue<int, int>();
       foreach(int a in nums)
       {
           minHeap.Enqueue(a, a);
           if(minHeap.Count>k)
           {
               minHeap.Dequeue();
           }
       }  

       return minHeap.Dequeue();
    }
