public class Solution {
    public int NumDistinct(string s, string t) 
    {
        //dp[i,0]都是1
        //dp[0,j]都是0
        //這兩個後面都不會變
        int[,] dp = new int[s.Length+1 , t.Length+1];    
        for(int i =0; i<s.Length; i++)
        {
            dp[i,0] = 1;;
        }

        for(int i = 1; i<s.Length+1; i++)
        {
            for(int j = 1; j<t.Length+1; j++)
            {
                if(s[i-1] == t[j-1])
                {
                    dp[i,j] = dp[i-1 , j-1] + dp[i-1 , j];//上一個字的方法數和上一層同位置的數相加
                }
                else
                {
                    dp[i,j] = dp[i-1 , j];//沒對上用上一層的數
                }
            }
        }

        return dp[s.Length , t.Length];
    }
}
