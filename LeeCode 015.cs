public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) 
    {
        var result = new List<IList<int>>();
        Array.Sort(nums);

        for(int i =0; i<nums.Length-2;i++)
        {
            int n1 = nums[i];
            if(n1>0)break;
            if(i>0 && n1==nums[i-1])continue;

            int left = i+1;
            int right = nums.Length-1;

            while(left<right)
            {
                int n2 = nums[left];
                int n3 = nums[right];
                int sum = n1+n2+n3;

                if(sum>0)right--;
                else if(sum<0)left++;
                else
                {
                    result.Add(new List<int>{n1,n2,n3});
                    if(left<right && n2==nums[left])left++;
                    if(left<right && n3==nums[right])right--;
                }
            }
        }
        return result;
    }
}
