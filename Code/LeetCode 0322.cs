public class Solution {
    public int CoinChange(int[] coins, int amount) 
    {
        int[] dp = new int[amount+1];
        dp[0] = 0;

        for(int i = 1; i <= amount; i++)//先給0以外的都加上最大值
        {
            dp[i] = int.MaxValue;
        }

        for(int i = 0; i < coins.Length; i++)//coins外
        {
            for(int j = coins[i]; j <= amount; j++)//背包容量內
            {
                if(dp[j - coins[i]] != int.MaxValue)
                {
                    dp[j] = Math.Min(dp[j] , dp[j - coins[i]]+1);
                }
            }
        }
        if(dp[amount] == int.MaxValue)return -1;//沒找到組合
        else return dp[amount];
    }
}
