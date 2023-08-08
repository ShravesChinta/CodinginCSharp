public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
      Dictionary<int, int> map=new Dictionary<int, int>();
      PriorityQueue<int, int> pq=new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => map[a] - map[b]));
      int[] result=new int[k];

      foreach(int a in nums)
      {
          if(map.ContainsKey(a))
          {
              map[a]++;
          }
          else
          {
              map[a]=1;
          }
      }

      foreach(int a in map.Keys)
      {
          pq.Enqueue(a, a);
          if(pq.Count>k)
          {
              pq.Dequeue();
          }
      } 

      for(int i=0;i<k;i++)
      {
          result[i]=pq.Dequeue();
      }

      return result;
    }
}
