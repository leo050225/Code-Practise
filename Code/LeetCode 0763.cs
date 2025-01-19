public class Solution {
    public IList<int> PartitionLabels(string s) 
    {
        int[] location = new int[27];

        for(int i = 0; i<s.Length; i++)
        {
            location[s[i] - 'a'] = i;//統計最每個字母最後出現的位置
        }

        List<int> res = new List<int>();
        int left = 0;
        int right = 0;

        for(int i =0; i<s.Length; i++)
        {
            right = Math.Max(right,location[s[i] - 'a']);//更新邊界

            if(i == right)//到達了最遠的邊界
            {
                res.Add(right - left + 1);//區間字數量
                left = i + 1;//更新區間起始位置
            }
        }
        return res;
    }
}
