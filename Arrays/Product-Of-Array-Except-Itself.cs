public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] left=new int[nums.Length];
        int[] right=new int[nums.Length];
        int[] prod=new int[nums.Length];

        left[0]=1;
        right[nums.Length-1]=1;

        for(int i=1;i<nums.Length;i++)
        {
            left[i]=left[i-1]*nums[i-1];
        }

        for(int i=nums.Length-2;i>=0;i--)
        {   
            right[i]=right[i+1]*nums[i+1];
        }

        for(int i=0;i<nums.Length;i++)
        {
            prod[i]=left[i]*right[i];
        }
        return prod;
    }
}
