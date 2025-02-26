public class Solution {
    public bool IsSubsequence(string s, string t) 
    {
        int[,] dp = new int[s.Length + 1 , t.Length + 1];

        for(int i = 1; i<=s.Length; i++)
        {
            for(int j = 1; j<=t.Length; j++)
            {
                if(s[i-1] == t[j-1])//文字一樣
                {
                    dp[i,j] = dp[i-1,j-1]+1;
                }
                else
                {
                    dp[i,j] = dp[i,j-1];
                }
            }
        }
        if(dp[s.Length , t.Length] == s.Length)return true;
        else return false;
    }
}
