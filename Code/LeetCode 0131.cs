public class Solution 
{
    public IList<IList<string>> Partition(string s) 
    {
        BackTracking(s,0);
        return res;
    }

    public IList<IList<string>> res = new List<IList<string>>();//存放結果的集合
    public IList<string> path = new List<string>();//存放目前的結果

    public void BackTracking(string s, int start)
    {
        if(start >= s.Length)//若起始位置大於s的大小 代表已經找到一組分割方案
        {
            res.Add(new List<string>(path));//集合加入到結果
            return;//返回
        }

        for(int i = start; i<s.Length; i++)//分割循環
        {
            if(IsPalindorme(s,start,i))//判斷是否是回文子串
            {
                path.Add(s.Substring(start,i - start +1));//擷取從開頭開始指定數量的字 加入到集合
            }
            else
            {
                continue;//跳過目前的循環
            }
            BackTracking(s,i+1);//從擷取下一位開始
            path.RemoveAt(path.Count -1);//回朔
        }
    }

    public bool IsPalindorme(string s , int start, int end)//字串 開頭 結尾
    {
        for(int i =start , j = end; i<j;i++,j--)//判斷是否為回文子串
        {
            if(s[i] != s[j]) return false;//如果有不同返回false
        }
        return true;//是回文子串 返回false
    }
}
