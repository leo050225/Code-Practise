using System.Text;

public class Solution {
    public string RemoveDuplicates(string s)
    {
        StringBuilder res = new StringBuilder();

        foreach(char c in s)
        {
            if(res.Length>0 && res[res.Length-1]==c)
            {
                res.Remove(res.Length-1,1);
            }
            else
            {
                res.Append(c);
            }
        }
        return res.ToString();
    }
}
