public class Solution {
    public int UniquePaths(int m, int n) 
    {
        int[] dp = new int[n];

        for(int i =0; i<n; i++)dp[i] = 1;

        for(int i = 1; i<m; i++)//走m*n的格子
        {
            for(int j = 1; j<n; j++)
            {
                dp[j] += dp[j-1];
            }
        }

        return dp[n-1];
    }
}
