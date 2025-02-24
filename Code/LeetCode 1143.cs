public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) 
	{
        int[] dp = new int[text2.Length + 1];

		for(int i = 1; i<=text1.Length; i++)
		{
			int pre = dp[0];
			for(int j = 1; j<=text2.Length; j++)
			{
				int cur = dp[j];//紀錄dp[i-1][j]

				if(text1[i-1] == text2[j-1])
				{ 
					dp[j] = pre + 1;//dp[i-1][j-1] + 1
				}
				else
				{
					dp[j] = Math.Max(dp[j] , dp[j-1]);//Max(dp[i-1][j] , dp[i][j-1])
				}

				pre = cur;//紀錄dp[i-1][j-1]
			}
		}
		return dp[text2.Length];
    }
}
