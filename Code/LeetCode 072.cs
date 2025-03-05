public class Solution {
    public int MinDistance(string word1, string word2) 
    {
        int[,] dp = new int[word1.Length+1 , word2.Length+1];

        //操作次數
        for(int i =1; i <word1.Length+1; i++)dp[i,0] = i;    
        for(int i =1; i <word2.Length+1; i++)dp[0,i] = i;

        for(int i =1; i<word1.Length+1; i++)
        {
            for(int j = 1; j<word2.Length+1; j++)
            {
                if(word1[i-1] == word2[j-1])
                {
                    dp[i,j] = dp[i-1 , j-1];
                }
                else
                {
                    dp[i,j] = Math.Min(dp[i-1,j-1] , Math.Min(dp[i-1,j] , dp[i , j-1]))+1;
                    //不同的時候 選擇操作最少的流程 + 一個操作 
                }
            }
        }

        return dp[word1.Length , word2.Length];
    }
}L
