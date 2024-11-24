public class Solution {
    public int MinSubArrayLen(int target, int[] nums) 
    {
        int len = nums.Length;

        if(len == 0)
        {
            return 0;
        }
        int start = 0;
        int end = 0;
        int ans = int.MaxValue;
        int sum = 0;

        while(end<len)
        {
            sum+=nums[end];
            while(sum>=target)
            {
                ans = Math.Min(ans , end-start+ 1);
                sum-=nums[start];
                start++;
            }

            end++;
        }

        return ans ==int.MaxValue ? 0 :ans;
    }
}
