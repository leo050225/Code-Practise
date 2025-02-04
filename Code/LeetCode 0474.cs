public class Solution {
    public int FindMaxForm(string[] strs, int m, int n) 
    {
        int[,] dp = new int[m+1 , n+1];    

        foreach(string str in strs)
        {
            int zero = 0;
            int one = 0;
            foreach(char c in str)//篩選單位的數量
            {
                if(c == '0')zero++;
                else one++;
            }

            for(int i = m; i >= zero; i--)//從後向前遍歷 確保不會重複加到
            {
                for(int j = n; j>=one; j--)
                {
                    dp[i,j] = Math.Max(dp[i,j] , dp[i - zero , j - one] + 1);//+1 是指子集長度增加1
                }
            }
        }
        return dp[m,n];
    }
}
