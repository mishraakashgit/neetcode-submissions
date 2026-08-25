public class Solution {
    public int MaxProfit(int[] prices) {
        int maxPrice = 0;
        int minPrice = int.MaxValue;

        foreach(int price in prices)
        {
            if(price < minPrice) minPrice = price;
            else maxPrice = Math.Max(maxPrice, price - minPrice);
        }

        return maxPrice;
    }
}
