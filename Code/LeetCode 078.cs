public class Solution {
    public IList<IList<int>> Subsets(int[] nums) 
    {
        BackTracking(nums,0);//調用
        return res;//返回
    }

    IList<IList<int>> res = new List<IList<int>>();//結果集合
    IList<int> path = new List<int>();//當前集合

    public void BackTracking(int[] nums, int start)
    {
        res.Add(new List<int>(path));//加入結果集合

        if(start > nums.Length) return ;//終止條件

        for(int i =start; i<nums.Length;i++)//循環
        {
            path.Add(nums[i]);//加入集合
            BackTracking(nums,i+1);//遞歸
            path.RemoveAt(path.Count - 1);//回朔
        }
    }
}
