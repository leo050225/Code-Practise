public class Solution {
    public int WiggleMaxLength(int[] nums) 
    {
        if(nums.Length < 2)return nums.Length;

        int curDiff = 0;//當前一對的差值
        int preDiff = 0;//前一對的差值
        int res = 1;//峰值個數 序列默認最右邊有一個峰值

        for(int i =0; i<nums.Length-1; i++)
        {
            curDiff = nums[i+1] - nums[i];//差值

            if((curDiff > 0 && preDiff <=0) || (curDiff < 0 && preDiff >=0))
            {
                res++;
                preDiff = curDiff;//記錄前一對差值
            }
        }
        return res;
    }
}
