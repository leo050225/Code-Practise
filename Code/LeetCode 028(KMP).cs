public class Solution {
    public int StrStr(string haystack, string needle) 
    {
        if(needle.Length == 0)//如果是空字串返回0
        {
            return 0;
        }
        if(needle.Length > haystack.Length || haystack.Length == 0)//如果needle不是haystack的一部分(haystack空字串)
        {
            return -1;//返回-1
        }

        return KMP(haystack,needle);//使用KMP的結果
    }

    private int KMP(string haystack, string needle)
    {                                //          EX:a a b a a f
        int[] next = GetNext(needle);//使用前綴表 EX:0 1 0 1 2 0
        int j = 0;//前綴
        int i = 0;//後綴

        while(i < haystack.Length)//開始遍歷
        {
            if(haystack[i]==needle[j])//如果兩個字串有連續匹配到同個字的話
            {
                j++;//needle的指標
                i++;//haystack的指標
            }
            if(j == needle.Length)//如果成功遍歷完needle字串的話代表匹配
            {
                return i-j;//返回haystack的匹配起始位置
            }
            else if(i<haystack.Length && haystack[i] != needle[j])//如果還在匹配失敗
            {
                if(j != 0)//如果needle的指標不再起始位置
                {
                    j = next[j-1];//用next前綴表來決定下一個位置
                }
                else
                {
                    i++;//如果j是起始位置0的話 i向右移一位
                }
            }
        }
        return -1;//如果沒有找到匹配的話返回-1
    }

    private int[] GetNext(string str)//製作前綴表
    {
        int[] next = new int [str.Length];//初始化前綴表
        next[0] = 0;//第一位設為0
        int j = 0;//指向前綴
        int i = 1;//指向後綴

        while(i<str.Length)//遍歷needle 建立前綴表next
        {
            if(str[i]==str[j])//如果前後兩個數字相同的話
            {
                j++;//前綴向右移
                next[i] = j;//i位置的前綴表數字是前一位的前綴表數字+1
                i++;//後綴向右移
            }
            else//前後綴不相同的時候
            {
                if(j==0)//如果現在等於0就是初始位置 無法回退
                {
                    next[i] = 0;//因為不同 所以是新的字母 所以附值0
                    i++;//向右移
                }
                else
                {
                    j = next[j-1];//前綴回退
                }
            }
        }
        return next;//返回數組
    }
}
