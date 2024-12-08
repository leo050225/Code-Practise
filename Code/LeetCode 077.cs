public class Solution 
{
    public IList <IList<int>> res = new List<IList<int>>();//存放符合條件的集合
    public IList<int> path = new List<int>();//存放符合條件的單一結果

    public IList<IList<int>> Combine(int n, int k) 
    {
        BackTrackint(1,n,k);//調用方法 起始是1 結尾是n 組合大小是k
        return res;//返回符合結果的集合
    }

    public void BackTrackint(int start,int n,int k)
    {
        if(path.Count==k)//符合組合大小的集合
        {
            res.Add(new List<int>(path));//把目前符合組合大小的集合 加入倒res裡
            return;//返回
        }

        for(int i = start; i<=n - (k - path.Count) + 1; i++)//確認起始數和這層循環的邊界 每層都會比上一層邊界-1
        {
            path.Add(i);//當前數字加入倒path裡
            BackTrackint(i+1,n,k);//從下一個數開始遞歸
            path.RemoveAt(path.Count - 1);//撤銷 回朔到上一步
        }
    }
}
