//Using HashSet in C#

public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> set=new HashSet<int>();
        foreach(int a in nums)
        {
            if(set.Contains(a))
            return true;

            set.Add(a);
        }
        return false;
    }
}
