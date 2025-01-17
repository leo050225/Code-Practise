public class Solution {
    public int FindMinArrowShots(int[][] points) 
    {
        if(points.Length == 0) return 0;

        Array.Sort(points, (a,b) => a[0].CompareTo(b[0]));//比起始位置 小排到大

        int count = 1;//如果points不為空 至少一隻箭

        for(int i = 1; i<points.Length; i++)
        {
            if(points[i][0] > points[i-1][1]) count++;//如果兩個沒在一條線上

            else points[i][1] = Math.Min(points[i][1], points[i-1][1]);//如果兩個在一條線上
        }

        return count;
    }
}
