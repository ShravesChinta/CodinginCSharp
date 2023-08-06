public class Solution {
    public int MaxArea(int[] height) {
    int area=0;
    int start=0;
    int end=height.Length-1;
    int width=0;

    while(start<end)
    {

        width=end-start;
        area=Math.Max(area, width*Math.Min(height[end],height[start]));
        Console.WriteLine(area);
        if(height[start]<height[end])
        {
            start++;
        }
        else
        {
            end--;
        }
    }

    return area;
    }
}
