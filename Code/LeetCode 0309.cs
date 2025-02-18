public class Solution {
    public int MaxProfit(int[] prices) 
    {
        int[] dp = new int[4];

        dp[0] = -prices[0];
        dp[1] = 0;
        dp[2] = 0;
        dp[3] = 0;

        for(int i = 0; i <prices.Length; i++)
        {
            int temp = dp[0];
            int temp1 = dp[2];

            dp[0] = Math.Max(dp[0] , Math.Max(dp[3] , dp[1]) - prices[i]);//狀態1 買入股票
            dp[1] = Math.Max(dp[1] , dp[3]);//狀態2 已經賣出 昨天是冷凍期
            dp[2] = temp + prices[i];//狀態3 金天賣出 所以昨天是dp[0] 持股
            dp[3] = temp1;//狀態4 冷凍期
        }

        return Math.Max(dp[3] , Math.Max(dp[1] , dp[2]));
    }
}
