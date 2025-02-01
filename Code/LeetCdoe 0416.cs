public class Solution {
    public bool CanPartition(int[] nums) 
    {
        int sum = 0;

        foreach(int i in nums)
        {
            sum+=i;    
        }

        if(sum % 2 == 1)return false;//能對半代表能分成兩組
        
        int target = sum/2;

        int[] dp = new int[target+1];

        for(int i = 0; i <nums.Length; i++)
        {
            for(int j = target; j>=nums[i]; j--)//從後往前 確保每個只會添加一次
            {
                dp[j] = Math.Max(dp[j] , dp[j - nums[i]] + nums[i]);
            }
        }

        if(dp[target] == target)return true;

        return false;
    }
}
