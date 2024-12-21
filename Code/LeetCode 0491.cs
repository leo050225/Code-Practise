public class Solution {
    public IList<IList<int>> FindSubsequences(int[] nums) 
    {
        Backtracking(nums,0);//調用
        return res;//返回
    }

    public IList<IList<int>> res = new List<IList<int>>();//結果集合
    public IList<int> path = new List<int>();//集合

    public void Backtracking(int[] nums,int start)
    {
        if(path.Count > 1)//如果裡面已經有數字
        {
            res.Add(new List<int>(path));//加入到結果集合
        }

        HashSet<int> hs = new HashSet<int>();//記錄用過數字的數字表

        for(int i =start; i<nums.Length;i++)//循環
        {
            //path裡面有數字 且 如果path的最後一個數字大於數組目前數組的數字 或是 已經用過這個數字
            if(path.Count>0 && path[path.Count-1] > nums[i] ||hs.Contains(nums[i]))
            {
                continue;//跳過循環
            }
            hs.Add(nums[i]);//記錄用過的數字
            path.Add(nums[i]);//加入到集合
            Backtracking(nums,i+1);//遞歸
            path.RemoveAt(path.Count-1);//回朔
        }
    }
}
