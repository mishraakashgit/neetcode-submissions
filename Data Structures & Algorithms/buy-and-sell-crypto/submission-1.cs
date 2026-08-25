public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int i = 0;
        int j = 1;

        while(j<prices.Length)
        {
            if(prices[i]>prices[j])
            {
                i = j;
            }
            else
            {
                int profit = prices[j] - prices[i];
                maxProfit = Math.Max(profit,maxProfit);
                j++;
            }
        }

        return maxProfit;
    }
}
