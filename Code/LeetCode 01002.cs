public class Solution {
    public IList<string> CommonChars(string[] words) 
    {
        int[] c = new int[26];
        Array.Fill(c,int.MaxValue);

        foreach(string str in words)
        {
            int[] count = new int[26];
            foreach(char i in str)
            {
                count[i-'a']++;
            }
            for(int i  = 0 ; i<26;i++)
            {
                c[i] = Math.Min(c[i],count[i]);
            }
        }
        IList<string> letters = new List<string>();
        for(int i =0; i<26;i++)
        {
            string letter = ((char)('a'+i)).ToString();
            int counts = c[i];
            for(int j = 0;j<counts;j++)
            {
                letters.Add(letter);
            }
        }
        return letters;
    }
}
