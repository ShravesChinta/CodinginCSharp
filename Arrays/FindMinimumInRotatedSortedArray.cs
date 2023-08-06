public class Solution {
    public int FindMin(int[] nums) {
        int start=0, mid=0, end=nums.Length-1;
        while(start<end)
        {
            mid=start+(end-start)/2;
            if(nums[mid]>nums[end])
            {
                start=mid+1;
            }
            else
            {
                end=mid;
            }
        }
        return nums[start];


    }
}
