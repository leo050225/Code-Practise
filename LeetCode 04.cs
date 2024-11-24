public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) 
    {
        List<int> list = new List<int>();

        for(int i = 0; i <nums1.Length ;i++)
        {
            list.Add(nums1[i]);
        }
        for(int i = 0; i <nums2.Length ;i++)
        {
            list.Add(nums2[i]);
        }
        list.Sort();

        if(list.Count%2 == 1)
        {
            return list[list.Count/2];
        }   
        else
        {
            return (list[list.Count/2]+list[list.Count/2-1])/2.0;
        }

    }
}
