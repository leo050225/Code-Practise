public class Solution {
    public int RemoveDuplicates(int[] nums) 
    {
        int len = nums.Length;

        int i = 1;

        if(len == 0)
        {
            return 0;
        }

        for(int j = 1;j<len;j++)
        {
            if(nums[j] != nums[i-1])
            {
                nums[i] = nums[j];
                i++;
            }
        }
        return i;
    }
}
