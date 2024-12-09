public class Solution {
    public IList<IList<int>> CombinationSum3(int k, int n) 
    {
        BackTracking(k,n,0,1);//深度 目標值 總值 起始位置
        return res;//返回
    }

    IList<IList<int>> res = new List<IList<int>>();//存放結果集區
    IList<int> path = new List<int>();//存放符合條件的結果

    public void BackTracking(int k, int n ,int sum, int start)//k找的深度 n目標值 sum總值 start起始位置
    {
        if(sum > n)//大於目標值的話直接返回上一層 剪枝操作
        {
            return;
        }

        if(path.Count == k)//如果到了指定的深度
        {
            if(sum == n)//總值 = 目標值
            {
                res.Add(new List<int>(path));//將這個數組加入結果集合
            }
            return;//返回
        }

        for(int i =start ; i<=9 - (k-path.Count)+1; i++)
        {
            sum+=i;//總值增加當層的數
            path.Add(i);//集合理也加上去
            BackTracking(k,n,sum,i+1);//進入下一層
            sum-=i;//回朔
            path.RemoveAt(path.Count-1);//回朔
        }
    }
}
