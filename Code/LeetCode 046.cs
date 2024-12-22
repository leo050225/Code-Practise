public class Solution {
    public IList<IList<int>> Permute(int[] nums) 
    {
        bool[] used =  new bool[nums.Length];//bool表
        BackTracking(nums,used);//調用
        return res;//返回結果
    }

    public IList<IList<int>> res = new List<IList<int>>();//集合結果
    public IList<int> path = new List<int>();//集合

    public void BackTracking(int[] nums, bool[] used)
    {
        if(path.Count == nums.Length)//全部數字都遍歷過
        {
            res.Add(new List<int>(path));//加入結果集合
            return;//返回
        }

        for(int i = 0;i<nums.Length;i++)//循環
        {
            if(used[i])continue;//如果用過了當前序列的數字 跳過當前循環
            used[i] = true;//把用過的數字變成true
            path.Add(nums[i]);//加入集合
            BackTracking(nums,used);//遞歸
            used[i] = false;//回朔
            path.RemoveAt(path.Count-1);//回朔
        }
    }
}
