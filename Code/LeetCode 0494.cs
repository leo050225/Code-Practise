public class Solution {
    public int FindTargetSumWays(int[] nums, int target) 
    {
        //left - rgiht = target
        //left + right = sum
        //left = (sum + target)/2

        int sum  = 0;
        foreach(int i in nums)
        {
            sum+=i;
        }

        if(Math.Abs(target) > sum)return 0;//目標大於總和
        if((sum+target) % 2 == 1)return 0;//無解
        
        int bagSize = (sum+target) / 2;//其中一個組合

        int[] dp = new int[bagSize+1];
        dp[0] = 1;

        for(int i = 0; i < nums.Length; i++)
        {
            for(int j = bagSize; j >= nums[i]; j--)
            {
                dp[j] += dp[j - nums[i]];
            }
        }

        return dp[bagSize];
    }
}
