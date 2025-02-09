public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) 
    {
        HashSet<string> wordSet = new HashSet<string>(wordDict);

        bool[] dp = new bool[s.Length+1];
        dp[0] = true;

        for(int i =1; i <= s.Length; i++)
        {
            for(int j = 0; j < i; j++)
            {
                string word = s.Substring(j , i-j);// j到i位置的子串

                if(wordSet.Contains(word) && dp[j])//如果dp[j]是true 且j到i有找到 = dp[i]也為true;
                {
                    dp[i] = true;
                    break;
                }
            }
        }
        return dp[s.Length];//最後是否為true
    }
}
