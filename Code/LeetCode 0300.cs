public class Solution {
    public int LengthOfLIS(int[] nums) 
    {
      if(nums.Length <= 1)return nums.Length;

      int[] dp = new int[nums.Length];

      int res = 1;
      
      for(int i = 0; i<nums.Length; i++)//都先填充1
      {
        dp[i] = 1;
      }

      for(int i = 1; i < dp.Length; i++)
      {
        for(int j = 0; j < i; j++)
        {
          if(nums[i] > nums[j])
          {
            dp[i] = Math.Max(dp[i] , dp[j] +1);//目前最長長度 目前位置的長度+1
          }
        }
        res = Math.Max(res , dp[i]);//紀錄當前循環的最大長度
      }

      return res;
    }
}
