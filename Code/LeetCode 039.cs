public class Solution 
{
    public IList<IList<int>> CombinationSum(int[] candidates, int target) 
    {
        Array.Sort(candidates);//排列BackTracking(candidates,target,0,0);//調用
        BackTracking(candidates,target,0,0);//調用
        return res;//返回
    }

    IList<IList<int>> res = new List<IList<int>>();//結果集合
    IList<int> path = new List<int>();//目前有的

    public void BackTracking(int[] candidates, int target , int start ,int sum)
    {
        if(sum > target) return;//太大的話返回

        if(sum == target)//總和=目標
        {
            res.Add(new List<int>(path));//加入到結果合集
            return;//返回
        }

        for(int i = start; i < candidates.Length && sum + candidates[i] <= target; i++)
        {
            sum+=candidates[i];//增加總和
            path.Add(candidates[i]);//加入到集合
            BackTracking(candidates ,target , i,sum);//遞歸
            sum-=candidates[i];//回朔
            path.RemoveAt(path.Count -1);//回朔
        }
    }
}
