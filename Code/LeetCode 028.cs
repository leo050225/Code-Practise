public class Solution {
    public int StrStr(string haystack, string needle) 
    {
        if(needle.Length ==0)
        {
            return 0;
        }
        if(haystack.Length==0 || needle.Length>haystack.Length)
        {
            return -1;
        }

        return KMP(haystack,needle);
    }

    private int KMP(string haystack, string needle)
    {
        int[] next = GetNext(needle);
        int h =0;
        int n =0;

        while(h<haystack.Length)
        {
            if(haystack[h] == needle[n])
            {
                h++;
                n++;
            }
            if(n==needle.Length)
            {
                return h-n;
            }
            else if(h<haystack.Length && haystack[h] != needle[n])
            {
                if(n!=0)
                {
                    n = next[n-1];
                }
                else
                {
                    h++;
                }
            }
        }
        return -1;
    }
    
    private int[] GetNext(string str)
    {
        int[] next = new int[str.Length];
        next[0] = 0;
        int j = 0;
        int i =1;

        while(i<str.Length)
        {
            if(str[j]==str[i])
            {
                j++;
                next[i] =j;
                i++;
            }
            else
            {
                if(j!=0)
                {
                    j=  next[j-1];
                }
                else
                {
                    next[i] = j;
                    i++;
                }
            }
        }
        return next;
    }
}
