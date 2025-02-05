public class Solution {
    public int Change(int amount, int[] coins) 
    {
        int[] dp = new int[amount+1];
        dp[0] = 1;//一種方法 不裝東西

        for(int i = 0; i < coins.Length; i++)//遍歷物品
        {
            for(int j = coins[i]; j<=amount; j++)//遍歷背包
            {
                if(j >= coins[i])//
                {
                    dp[j] += dp[j - coins[i]];
                }
            }
        }
        return dp[amount];
    }
}
