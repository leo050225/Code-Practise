public class Solution {
    public int UniquePathsWithObstacles(int[][] obstacleGrid) 
    {
        int m = obstacleGrid.Length;
        int n = obstacleGrid[0].Length;

        int[,] dp = new int[m,n];

        for(int i = 0; i<m && obstacleGrid[i][0] == 0; i++)dp[i,0] = 1;
        for(int i = 0; i<n && obstacleGrid[0][i] == 0; i++)dp[0,i] = 1;

        for(int i =1; i<m; i++)
        {
            for(int j = 1; j<n; j++)
            {
                if(obstacleGrid[i][j] == 1)continue;//遇到障礙
                dp[i,j] = dp[i-1,j] + dp[i,j-1];
            }
        }

        return dp[m-1,n-1];
    }
}
