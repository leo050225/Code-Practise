public class Solution {
    public int FindLengthOfLCIS(int[] nums) 
    {
		if(nums.Length<=1)return nums.Length;

		int[] dp = new int[nums.Length];

       	for(int i = 0; i<dp.Length; i++)
       	{
			dp[i] = 1;
       	}

       	int res = 1;
		
		for(int i = 0; i<nums.Length-1; i++)
		{
			if(nums[i+1] > nums[i])
			{
				dp[i+1] = dp[i] + 1;//用前一個+1
			}
			res = Math.Max(res , dp[i+1]);//比較之前最長和目前最長
		}
		return res;
    }
}
