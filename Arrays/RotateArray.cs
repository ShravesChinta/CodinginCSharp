public class Solution {
    public void Rotate(int[] nums, int k) {
       k=k%nums.Length;
       rotateA(0,nums.Length-1,nums);
       rotateA(0,k-1,nums);
       rotateA(k,nums.Length-1,nums); 
    }

    public void rotateA(int start, int end, int[] nums)
    {
        while(start<end)
        {
            int temp=nums[start];
            nums[start]=nums[end];
            nums[end]=temp;

            start++;
            end--;
        }

    }
}
