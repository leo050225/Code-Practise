public class Solution {
    public bool IsAnagram(string s, string t) 
    {
        int sl = s.Length;
        int tl  = t.Length;

        if(sl!=tl)return false;

        int[] a = new int[26];

        for(int i = 0;i<sl;i++)
        {
            a[s[i] - 'a']++;
            a[t[i] - 'a']--;
        }

        foreach (int i in a)
        {
            if(i!=0)
            {
                return false;
            }
        }
        return true;
    }
}
