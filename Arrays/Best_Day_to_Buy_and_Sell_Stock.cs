public class Solution {
    public int MaxProfit(int[] prices) {
        int max_profit=0;
        int buy_day=int.MaxValue;

        foreach(int a in prices)
        {
            if(buy_day>a)
            {
                buy_day=a;
            }
            else
            {
                int diff=a-buy_day;
                max_profit=Math.Max(diff,max_profit);
            }
        }

        return max_profit;
        
    }
}
