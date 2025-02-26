public class Solution {
    public int MaxSubArray(int[] nums) 
    {
        int[] dp = new int[nums.Length];

        dp[0] = nums[0];
        int result = dp[0];
        
        for(int i =1; i<nums.Length; i++)
        {
            dp[i] = Math.Max(dp[i-1]+nums[i] , nums[i]);

            if(dp[i] > result) result = dp[i];//當前的數大於目前的總和
        }

        return result;
    }
}
