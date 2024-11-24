public class Solution {
    public int[] SortedSquares(int[] nums) 
    {
        int len = nums.Length;

        int[] ans = new int[len];

        int j = len - 1;
        int pos = len - 1;

        for(int i =0;i<=j;)
        {
            int i2 = nums[i]*nums[i];
            int j2 = nums[j]*nums[j];
            if(i2>j2)
            {
                ans[pos] = i2;
                i++;
            }
            else
            {
                ans[pos] = j2;
                j--;
            }
            pos--;
        }
        return ans;
    }
}
