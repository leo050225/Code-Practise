public class Solution {
    public int NumTrees(int n) 
    {
        int[] dp = new int[n+1];

        dp[0] = 1;

        for(int i = 1; i <= n; i++)
        {
            for(int j = 1; j<=i; j++)
            {
                dp[i] += dp[j-1] * dp[i-j];//左子樹的節點數量 * 右子樹節點數量
            }
        }
        return dp[n];
    }
}
