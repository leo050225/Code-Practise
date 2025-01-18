public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) 
    {
        if(intervals.Length == 0)return 0;

        Array.Sort(intervals, (a,b) => a[1].CompareTo(b[1]));//用右邊邊界 從小排到大

        int res = 1;
        int end = intervals[0][1];//右邊邊界

        for(int i = 0; i<intervals.Length; i++)
        {
            if(end <= intervals[i][0])//如果左邊 >= 右邊邊界
            {
                end = intervals[i][1];//更換
                res++;//非交互區間數
            }
        }

        return intervals.Length - res;//削去區間數量
    }
}
