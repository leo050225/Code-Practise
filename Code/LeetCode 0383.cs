public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) 
    {
        if(ransomNote.Length > magazine.Length)return false;

        int[] letters = new int[26];

        foreach(char c in magazine)
        {
            letters[c-'a']++;
        }
        foreach(char c in ransomNote)
        {
            letters[c-'a']--;
            if(letters[c-'a']<0)
            {
                return false;
            }
        }
        return true;
    }
}
