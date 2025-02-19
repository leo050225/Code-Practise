public class Solution {
    public int MaxProfit(int[] prices, int fee) 
    {
        int[] dp = new int[2];

        dp[0] = -prices[0];
        dp[1] = 0;

        for(int i = 0; i<prices.Length; i++)
        {
            dp[0] = Math.Max(dp[0] , dp[1] - prices[i]);//買進
            dp[1] = Math.Max(dp[1] , dp[0] + prices[i] - fee);//賣出
        }

        return dp[1];
    }
}
