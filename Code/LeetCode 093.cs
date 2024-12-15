public class Solution {
    public IList<string> RestoreIpAddresses(string s) 
    {
            if(s.Length < 4 || s.Length > 12) return res;//如果字串太小或是太大 返回false
            Backtracking(s,0,0);//調用方法
            return res;//返回
    }

    public IList<string> res = new List<string>();//結果集合

    public void Backtracking(string s, int start ,int pointSum)//字串 起始位置 逗號數量
    {
        if(pointSum == 3)//逗點數量為3(已經分出4段的時候)的時候 分隔結束
        {
            if(IsVlid(s , start , s.Length -1))//判斷4段子串是否符合條件
            {
                res.Add(s);//符合條件的話加入到結果集合
            }
            return;//返回
        }

        for(int i = start ; i<s.Length ; i++)
        {
            if(IsVlid(s , start , i))//判斷這個start ~ i的這個區間有沒有符合規則
            {
                s = s.Insert(i + 1 , ".");//在i後面加入一個逗號
                Backtracking(s, i+2 , pointSum+1);//調用方法 從逗號後面的位置開始 逗號數量+1
                s = s.Remove(i + 1 , 1);//回朔
            }
            else break;//區間不合規則的話 中斷循環 後面都不用了
        }
    }

    public bool IsVlid(string s, int start,int end)//檢測start~end這段字串有沒有符合規則
    {
        if(start > end)return false;//返回false

        if(s[start] == '0' &&  start != end)return false;//開頭是0 不合規則 返回false

        int num = 0;//儲存這個區間的數字

        for(int i =start; i<=end; i++)
        {
            if(s[i] > '9' || s[i] < '0')return false;//遇到非數字字符 不符合規則 返回false

            num = num * 10 +s[i] -'0';//字符轉換成數字還有進位 拼出完整的數字
            //EX:num = 23 然後s[i] = 7   23先變230再加7

            if(num > 255)return false;//大於255 不符合規則
        }
        return true;//都符合規則的話 返回true
    }
}
