public class Solution {
    public int MaxProfit(int[] prices) 
    {
        int[] dp = new int[2];

        dp[0] = -prices[0];//持有
        dp[1] = 0;//賣出

        for(int i = 1; i<=prices.Length; i++)
        {
            dp[0] = Math.Max(dp[0] , -prices[i-1]);//前一天持有 或 當天買入

            dp[1] = Math.Max(dp[1] , dp[0] + prices[i-1]);//前一天賣出 或 當天賣出
        }

        return dp[1];//返回賣出的錢
    }
}
