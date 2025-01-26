public class Solution {
    public int MinCostClimbingStairs(int[] cost) 
    {
        int[] dp = new int[]{0,0};

        for(int i = 2; i<=cost.Length; i++)
        {
            int temp = Math.Min(dp[0]+cost[i-2] , dp[1]+cost[i-1]);//到達當前節點的最後一布 走一層 OR 走兩層
            dp[0] = dp[1];
            dp[1] = temp;
        }
        
        return dp[1];
    }
}
