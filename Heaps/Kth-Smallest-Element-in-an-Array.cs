public class Solution {
    public int FindKthSmallest(int[] nums, int k) {
       PriorityQueue<int,int> maxHeap=new PriorityQueue<int,int>();
       foreach(int a in nums)
       {
           maxHeap.Enqueue(-a, -a);
           if(maxHeap.Count>k)
           maxHeap.Dequeue();

       }

       return -(maxHeap.Dequeue());
    }
}
