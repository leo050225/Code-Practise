public class Solution {
    public bool CanJump(int[] nums) 
    {
        int cover = 0;
        if(nums.Length == 1) return true;

        for(int i = 0; i<=cover; i++)//要小於等於cover 代表目前能到的最遠下標位置
        {
            cover = Math.Max(i+nums[i],cover);//取覆蓋面積最大的值
            if(cover >= nums.Length -1) return true;//如果覆蓋面積有超過數組最後一位下標的話 代表能抵達最後一位
        }
        return false;
    }
}
