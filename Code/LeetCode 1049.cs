public class Solution {
    public int LastStoneWeightII(int[] stones) 
    {
        int[] dp = new int[15001];

        int sum = 0;

        foreach(int i in stones)
        {
            sum+=i;
        }

        int target = sum/2;
        
        for(int i = 0; i < stones.Length; i++)
        {
            for(int j = target; j >= stones[i]; j--)
            {
                dp[j] = Math.Max(dp[j] , dp[j - stones[i]] + stones[i]);
            }
        }
        return sum - 2 * dp[target];
        //兩堆石頭 dp[target] 、sum/2 - dp[target]
        //dp[target] <= sum/2 - dp[target]
    }
}
