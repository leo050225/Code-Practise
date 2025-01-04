public class Solution {
    public int FindContentChildren(int[] g, int[] s) 
    {
        Array.Sort(g);//排序
        Array.Sort(s);//排序

        int index = s.Length-1;//從最大的餅乾開始
        int res = 0;//最大滿足人數

        for(int i = g.Length-1 ; i>=0 ; i--)//從胃口最大的開始
        {
            if(index>=0 && s[index] >= g[i])//要有餅乾
            {
                res++;
                index--;
            }
        }
        return res;
    }
}
