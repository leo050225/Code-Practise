public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) 
    {
        if(nums1==null || nums1.Length==null || nums2==null || nums2.Length==null)
        {
            return new int[0];
        }
        HashSet<int> one = Insert(nums1);
        HashSet<int> two = Insert(nums2);

        one.IntersectWith(two);
        return one.ToArray();

    }

    public HashSet<int> Insert(int[] nums)
    {
        HashSet<int> one = new HashSet<int>();
        
        foreach(int num in nums)
        {
            one.Add(num);
        }
        return one;
    }
}
