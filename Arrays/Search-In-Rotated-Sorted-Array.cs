public class Solution {
    public int Search(int[] nums, int target) {
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

        end=nums.Length-1;
        if(nums[start]<=target && nums[end]>=target)
        {
            start=start;
            end=end;
        }
        else
        {
            end=start;
            start=0;
        }

        while(start<=end)
        {
            mid=start+(end-start)/2;
            if(nums[mid]==target)
            return mid;

            else if(nums[mid]>target)
            {
                end=mid-1;
            }
            else
            {
                start=mid+1;
            }

        }

        return -1;

    }
}
