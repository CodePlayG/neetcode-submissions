public class Solution {
    public int MaxProfit(int[] prices) {
        int minPrice = int.MaxValue;
        int profit = 0;

        foreach(int price in prices)
        {
            minPrice = Math.Min(minPrice, price);
            profit = Math.Max(profit, (price - minPrice));
        }

        return profit;
    }
}