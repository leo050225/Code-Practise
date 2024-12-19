public class Solution {
    public IList<IList<int>> SubsetsWithDup(int[] nums) 
    {
        Array.Sort(nums);//照順序重新排列
        BackTracking(nums,0);//調用
        return res;//返回結果
    }

    public IList<IList<int>> res = new List<IList<int>>();//結果集和
    public IList<int> path = new List<int>();//集合

    public void BackTracking(int[] nums,int start)
    {
        res.Add(new List<int>(path));//加入結果集和

        for(int i =start; i<nums.Length;i++)
        {
            if(i > start && nums[i] == nums[i-1]) continue;//去重複

            path.Add(nums[i]);//加入集合
            BackTracking(nums,i+1);//遞歸
            path.RemoveAt(path.Count-1);//回朔
        }
    }
}
