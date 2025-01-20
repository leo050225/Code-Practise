public class Solution {
    public int[][] Merge(int[][] intervals) 
    {
        if(intervals.Length == 0)return intervals;

        Array.Sort(intervals,(a,b) => a[0].CompareTo(b[0]));

        List<List<int>> res = new List<List<int>>();

        res.Add(intervals[0].ToList());//先加入第一個範圍

        for(int i =1; i < intervals.Length; i++)
        {
            if(res[res.Count - 1][1] >= intervals[i][0])//範圍重疊 改寫範圍
            {
                res[res.Count - 1][1] = Math.Max(res[res.Count - 1][1],intervals[i][1]);
            }
            else
            {
                res.Add(intervals[i].ToList());
            }
        }
        return res.Select(x => x.ToArray()).ToArray();
    }
}
