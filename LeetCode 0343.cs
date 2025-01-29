public class Solution {
    public int IntegerBreak(int n) 
    {
        int[] dp = new int[n+1];

        dp[2] = 1;//2分割後的最大乘積

        for(int i = 3; i <= n; i++)
        {
            for(int j = 1; j <= i/2; j++)
            {
                dp[i] = Math.Max(dp[i] , Math.Max(j * (i-j) , j * dp[i-j]));
            }
        }

        return dp[n];
    }
}
