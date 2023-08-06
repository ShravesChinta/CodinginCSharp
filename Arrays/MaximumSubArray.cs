public class Solution {
    public int MaxSubArray(int[] nums) {
        int sum=0;
        int max_sum=int.MinValue;
        foreach(int a in nums)
        {

        sum=sum+a;
        max_sum=Math.Max(max_sum,sum);
        if(sum<=0)
        {
            sum=0;
        }

        }
        return max_sum;
        
    }
}
