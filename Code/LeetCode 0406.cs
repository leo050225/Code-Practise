public class Solution {
    public int[][] ReconstructQueue(int[][] people) //[[7,0],[4,4],[7,1],[5,0],[6,1],[5,2]]
    {
        Array.Sort(people,(a,b) => //先把高的往前排 再根據第二個數字排 [[7,0], [7,1], [6,1], [5,0], [5,2], [4,4]]
        {
            if (a[0]==b[0])//兩人第一個值相同
            {
                return a[1] - b[1];//用第二個值來排序
            }
            return b[0] - a[0];//不同 用第一個值來排序
        });

        var res = new List<int[]>();

        for(int i = 0; i<people.Length; i++)//直接根據前面人的數量插入對應位置 前面一定會大於插入的數字
        {
            res.Insert(people[i][1],people[i]);//[[5,0],[7,0],[5,2],[6,1],[4,4],[7,1]]
        }
        return res.ToArray();
    }
}
