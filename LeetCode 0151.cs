public class Solution {
    public string ReverseWords(string s) 
    {
        StringBuilder r = new StringBuilder();
        StringBuilder curr = new StringBuilder();

        for(int i = s.Length-1; i>=0; i--)
        {
            char c = s[i];
            if(c ==' ')
            {
                if(curr.Length>0)
                {
                    if(r.Length>0)
                    {
                        r.Append(' ');
                    }
                    for(int j = curr.Length-1;j>=0;j--)
                    {
                        r.Append(curr[j]);
                    }
                    curr.Length = 0;
                }
            }
            else
            {
                curr.Append(c);
            }
        }

        if(curr.Length>0)
        {
            if(r.Length>0)
            {
                r.Append(' ');
            }
            for(int i =curr.Length-1; i>=0; i--)
            {
                r.Append(curr[i]);
            }
        }
        return r.ToString();
    }
}
