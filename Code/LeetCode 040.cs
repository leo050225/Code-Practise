public class Solution 
{
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) 
    {
        Array.Sort(candidates);//排列
        BackTrack(candidates,target,0,0);//調用
        return res;//返回
    }

    IList<IList<int>> res = new List<IList<int>>();//結果的集合
    IList<int> path = new List<int>();//目前的集合

    public void BackTrack(int[] candidates, int target, int start , int sum)
    {
        if(sum > target)return;//太大的話返回

        if(sum == target)//總和=目標
        {
            res.Add(new List<int>(path));//加入到結果合集
            return;//返回
        }

        for(int i = start; i<candidates.Length && sum+candidates[i]<=target;i++)//sum + candidates[i]就是下一層的總和 如果大於的話中止for
        {
            if(i>start &&candidates[i]==candidates[i-1])continue;//如果現在的樹跟上一個數一樣的話

            sum+=candidates[i];//增加總和
            path.Add(candidates[i]);//加入到集合
            BackTrack(candidates,target,i+1,sum);//遞歸
            sum-=candidates[i];//回朔
            path.RemoveAt(path.Count-1);//回朔
        }
    }
}
