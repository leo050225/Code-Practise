public class Solution {
    public int MaxProfit(int k, int[] prices) 
    {
        if(prices.Length==0)return 0;
        if(k==0)return 0;

        int[] dp = new int[2 * k];

        for(int i = 0; i < dp.Length / 2; i++)//初始化 0和偶數是買入
        {
            dp[i * 2] = -prices[0];
        }

        for(int i = 1; i<=prices.Length; i++)
        {
            dp[0] = Math.Max(dp[0] , -prices[i-1]);
            dp[1] = Math.Max(dp[1] , dp[0] + prices[i-1]);

            for(int j = 2; j<dp.Length; j+=2)
            {
                dp[j] = Math.Max(dp[j] , dp[j-1] - prices[i-1]);
                dp[j+1] = Math.Max(dp[j+1] , dp[j] + prices[i-1]);
            }
        }
        return dp[dp.Length-1];
    }
}
