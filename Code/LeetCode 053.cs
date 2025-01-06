public class Solution {
    public int MaxSubArray(int[] nums) 
    {
        int res = int.MinValue;

        int count = 0;

        for(int i =0; i<nums.Length; i++)
        {
            count+=nums[i];
            res = Math.Max(res,count);

            if(count < 0) count = 0;//如果掉到負數 就歸零
        }
        return res;
    }
}
