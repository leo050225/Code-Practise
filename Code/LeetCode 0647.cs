public class Solution {
    public int CountSubstrings(string s) 
    {
        char[] c = s.ToCharArray();

        bool[,] dp = new bool[c.Length,c.Length];

        int result = 0;

        for(int i = c.Length-1; i>=0; i--)//dp[i,j]代表i~j之間是否為回文子串
        {
            for(int j = i; j < c.Length; j++)
            {
                if(c[i] == c[j])
                {
                    if(j - i <= 1 || dp[i+1,j-1])//避免重疊 或 i+1 ~ j-1是回文子串
                    {
                        result++;//回文子串數+1
                        dp[i,j] = true;//i~j是回文子串
                    }
                }
            }
        }
        return result;
    }
}
