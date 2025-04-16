public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) //6 5 4 8
    {
        Dictionary<int,int> dic = new Dictionary<int, int>();

        int[] res = (int[])nums.Clone();

        Array.Sort(res);//4 5 6 8

        for(int i = 0; i<res.Length; i++)
        {
            if(!dic.ContainsKey(res[i]))
            {
                dic[res[i]] = i;//4 5 6 8
                                //0 1 2 3
            }
        }

        for(int i = 0; i<nums.Length; i++)
        {
            res[i] = dic[nums[i]];
        }

        return res;
    }
}
