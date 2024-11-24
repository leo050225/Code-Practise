public class Solution {
    public int LengthOfLastWord(string s) 
    {
        int index = s.Length -1;

        while(s[index] ==' ')
        {
            index--;
        }

        int wordlen = 0;

        while(index >= 0 && s[index] != ' ')
        {
            wordlen++;
            index--;
        }
        return wordlen;
    }
}
