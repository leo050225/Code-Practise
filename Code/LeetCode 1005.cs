public class Solution {
    public int LargestSumAfterKNegations(int[] nums, int k) 
    {
        int res = 0;
        Array.Sort(nums,(a,b) => Math.Abs(b) - Math.Abs(a));//照絕對值順序排序

        for(int i = 0; i < nums.Length; i++)//將負數轉成正數 盡可能消耗k
        {
            if(nums[i] < 0 && k >0)
            {
                nums[i] *= -1;
                k--;
            }
        }

        if(k % 2 == 1) nums[nums.Length - 1] *= -1;//最小的數 反覆反轉 k剩餘偶數就不用反轉

        foreach(var item in nums) res += item;//數組總和

        return res;
    }
}
