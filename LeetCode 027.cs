public class Solution {
    public int RemoveElement(int[] nums, int val) 
    {
        int num = 0;
        for(int i =0; i<nums.Length; i++)
        {
            if(val != nums[i])
            {
                nums[num] = nums[i];
                num++;
            }
        }
        return num;
    }
}
