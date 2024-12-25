public class Solution {
    public IList<IList<int>> PermuteUnique(int[] nums) 
    {
        bool[] used = new bool[nums.Length];//bool表
        Array.Sort(nums);//照順序排列 避免重複數字沒在一起
        Backtracking(nums,used);//調用
        return res;//返回
    }

    public IList<IList<int>> res = new List<IList<int>>();//結果集合
    public IList<int> path = new List<int>();//集合

    public void Backtracking(int[] nums,bool[] used)
    {
        if(path.Count == nums.Length)
        {
            res.Add(new List<int>(path));//加入結果集合
            return;//返回
        }

        for(int i = 0;i<nums.Length;i++)
        {
            //如果跟前一個數字一樣且前一個數字還沒用過的話 跳過當前的數字 避免出現重複組合
            if(i>0 && nums[i]==nums[i-1]&&used[i-1]==false)continue;

            if(used[i])continue;//如果用過的話 跳過

            used[i] = true;//標記用過的數字
            path.Add(nums[i]);//加入集合
            Backtracking(nums,used);//遞歸
            used[i] = false;//回朔
            path.RemoveAt(path.Count-1);//回朔
        }
    }
}
