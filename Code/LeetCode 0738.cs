public class Solution {
    public int MonotoneIncreasingDigits(int n) 
    {
        char[] s = n.ToString().ToCharArray();//轉成字元陣列 123->"123"->["1","2","3"]

        int flag = s.Length;

        for(int i = s.Length-1 ; i > 0 ;i--)//紀錄不是單調遞增的
        {
            if(s[i-1] > s[i])
            {
                flag = i;
                s[i-1]--;
            }
        }

        for(int i = flag; i<s.Length ; i++)//變成最大數9
        {
            s[i] = '9';
        }

        return int.Parse(new string(s));
    }
}
