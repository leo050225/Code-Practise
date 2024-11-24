public class Solution {
    public IList<IList<int>> FourSum(int[] nums, int target) 
    {
        var result = new List<IList<int>>();
        Array.Sort(nums);

        for(int i = 0; i<nums.Length-3; i++)
        {
            var n1 = nums[i];
            if(i>0 && n1==nums[i-1])continue;

            for(int j = i+1;j<nums.Length-2; j++ )
            {
                var n2 = nums[j];
                if(j>i+1 && n2==nums[j-1])continue;

                int left = j+1;
                int right = nums.Length-1;

                while(left<right)
                {
                    var n3 = nums[left];
                    var n4 = nums[right];
                    var sum = (long)n1+n2+n3+n4;

                    if(sum>target)right--;
                    else if(sum<target)left++;
                    else
                    {
                        result.Add(new List<int>{n1,n2,n3,n4});
                        while(left<right && n3==nums[left])left++;
                        while(left<right && n4==nums[right])right--;
                    }
                }
            }
        }
        return result;
    }
}
