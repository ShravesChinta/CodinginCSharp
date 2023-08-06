public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        List<IList<int>> l=new List<IList<int>>();
        if(nums.Length<3)
        return l;

        Array.Sort(nums);
        for(int i=0;i<nums.Length-2;i++)
        {
            if(i==0 || i>0 && nums[i]!=nums[i-1])
            {
                int low=i+1;
                int high=nums.Length-1;
                while(low<high)
                {
                    if(nums[i]+nums[low]+nums[high]==0)
                   {
                        l.Add(new List<int>{nums[i],nums[low],nums[high]});
                    while(low<high && nums[low]==nums[low+1])low++;
                    while(high>0 && nums[high]==nums[high-1])high--;
                    low++;
                    high--;
                   }
                   else if(nums[i]+nums[low]+nums[high]>0)
                   {
                       high--;

                   }
                   else
                   {
                       low++;
                   }

                }
            }
        }

        return l;
    }
}
