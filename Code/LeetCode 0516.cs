public class Solution {
    public int LongestPalindromeSubseq(string s) 
    {
        int[,] dp = new int[s.Length + 1 , s.Length + 1];

        for(int i = s.Length-1;  i>=0; i--)//從後遍歷
        {
            dp[i,i] = 1;//每個位置的預設最長都是1

            for(int j = i+1; j<s.Length; j++)//從前
            {
                if(s[i] == s[j])//相等
                {
                    dp[i,j] = dp[i+1 , j-1]+2;//i~j的最長子串的長度是i+1~j-1的長度+2
                }

                else
                {
                    dp[i,j] = Math.Max(dp[i+1 , j] , dp[i , j-1]);//加入s[i]和加入s[j]
                }
            }
        }
        return dp[0 , s.Length-1];
    }
}
