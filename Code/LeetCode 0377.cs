public class Solution {
    public int CombinationSum4(int[] nums, int target) 
    {
        int[] dp = new int[target+1];
        dp[0] = 1;

        //求排列 外背包 內物品
        for(int i = 0; i <= target; i++)//遍歷背包
        {
            for(int j = 0; j < nums.Length; j++)//遍歷物品
            {
                if(i >= nums[j] && dp[i] < int.MaxValue - dp[i - nums[j]])//防止兩數相加超過intMaxValue
                {
                    dp[i] += dp[i - nums[j]];
                }
            }
        }
        return dp[target];
    }
}
