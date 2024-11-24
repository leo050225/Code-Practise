public class Solution 
{
    Dictionary<char,int> dc = new Dictionary<char, int>
    {
        {'I',1},
        {'V',5},
        {'X',10},
        {'L',50},
        {'C',100},
        {'D',500},
        {'M',1000},
    };

    public int RomanToInt(string s) 
    {
        int ans = 0;
        int n = s.Length;
        for(int i = 0; i<n ; i++)
        {
            int value = dc[s[i]];
            if(i<n-1 && value < dc[s[i+1]])
            {
                ans -= value;
            }
            else
            {
                ans+=value;
            }
        }
        return ans;
    }
}
