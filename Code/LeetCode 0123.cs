public class Solution {
    public int MaxProfit(int[] prices) 
    {
        int[] dp = new int[4];
        
        dp[0] = -prices[0];//第一次買入
        dp[1] = 0;//第一次賣出

        dp[2] = -prices[0];//第二次買入
        dp[3] = 0;//第二次賣出

        for(int i = 1; i <=prices.Length; i++)
        {
            dp[0] = Math.Max(dp[0] , -prices[i-1]);//第一次
            dp[1] = Math.Max(dp[1] , dp[0] + prices[i-1]);

            dp[2] = Math.Max(dp[2] , dp[1] - prices[i-1]);//第二次
            dp[3] = Math.Max(dp[3] , dp[2] + prices[i-1]);
        }
        return dp[3];
    }
}
