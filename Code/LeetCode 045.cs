public class Solution {
    public int Jump(int[] nums) 
    {
        int cur = 0;//當前覆蓋的最遠距離的下標
        int next = 0;//下一步最遠距離的下標
        int step = 0;//步數

        for(int i = 0; i<nums.Length - 1; i++)
        {
            next = Math.Max(next, i+nums[i]);//更新最遠距離
            if(i == cur)//遇到當嫌最遠距離的下標
            {
                cur = next;//更新
                step++;
            }
        }
        return step;
    }
}
