public class Solution {
    public int FindLength(int[] nums1, int[] nums2) 
	{
		int[] dp = new int[nums2.Length + 1];

		int result = 0;
		
		//從不同邊遍歷 然後找最大長度
		for(int i = 0; i<nums1.Length; i++)
		{
			for(int j = nums2.Length; j > 0; j--)
			{
				if(nums1[i] == nums2[j-1])
				{
					dp[j] = dp[j - 1] + 1;
				}
				else
				{
					dp[j] = 0;
				}
				result = Math.Max(result , dp[j]);
			}
		}
		return result;
    }
}
