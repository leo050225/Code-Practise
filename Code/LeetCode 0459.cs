public class Solution {
    public bool RepeatedSubstringPattern(string s) 
    {
        if(s.Length==0)
        {
            return false;
        }

        int[] next = GetNext(s);
        int len = s.Length;
        if(next[len-1]!=0 && len%(len-next[len-1])==0)
        {
            return true;
        }
        return false;
    }

    private int[] GetNext(string str)
    {
        int[] next = new int[str.Length];
        next[0] = 0;
        int j = 0;
        int i = 1;

        while(i<str.Length)
        {
            if(str[i]==str[j])
            {
                j++;
                next[i] = j;
                i++;
            }
            else
            {
                if(j==0)
                {
                    next[i] = 0;
                    i++;
                }
                else
                {
                    j = next[j-1];
                }
            }
        }
        return next;
    }
}
