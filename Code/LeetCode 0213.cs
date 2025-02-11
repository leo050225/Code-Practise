public class Solution {
    public int Rob(int[] nums) 
    {
        if(nums.Length == 0)return 0;
        if(nums.Length == 1)return nums[0];

        int result1 = RobRange(nums , 0 , nums.Length-2);//不計算最後一位
        int result2 = RobRange(nums , 1 , nums.Length-1);//不計算第一位

        return Math.Max(result1 , result2);
    }

    private int RobRange(int[] nums , int start , int end)
    {
        if(start == end)return nums[start];//兩間屋子都一樣

        int[] dp = new int[nums.Length];
        dp[start] = nums[start];
        dp[start+1] = Math.Max(nums[start] , nums[start+1]);

        for(int i = start+2; i<=end; i++)
        {
            dp[i] = Math.Max(dp[i-2] + nums[i] , dp[i-1]);
        }
        return dp[end];
    }
}
