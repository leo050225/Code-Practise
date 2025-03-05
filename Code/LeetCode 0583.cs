public class Solution {
    public int MinDistance(string word1, string word2) 
    {
        int[,] dp = new int[word1.Length+1 , word2.Length+1];
        
        //刪除元素的數量
        for(int i = 0; i<word1.Length+1; i++)dp[i,0] = i;
        for(int j = 0; j<word2.Length+1; j++)dp[0,j] = j;

        for(int i = 1; i<word1.Length+1; i++)
        {
            for(int j = 1; j<word2.Length+1; j++)
            {
                if(word1[i-1] == word2[j-1])
                {
                    dp[i,j] = dp[i-1,j-1];
                }
                else
                {
                    dp[i,j] = Math.Min(dp[i-1 , j-1] + 2 , Math.Min(dp[i-1 , j] + 1 , dp[i , j-1] + 1));
                    //取最小 最少步數
                }
            }
        }
        return dp[word1.Length , word2.Length];
    }
}
