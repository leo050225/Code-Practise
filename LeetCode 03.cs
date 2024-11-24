public class Solution {
    public int LengthOfLongestSubstring(string s) 
    {
        HashSet<char> letter = new HashSet<char>();
        int left = 0,right = 0;
        int length = s.Length;
        int count = 0,max = 0;

        while(right<length)
        {
            if(!letter.Contains(s[right]))
            {
                letter.Add(s[right]);
                right++;
                count++;
            }
            else
            {
                letter.Remove(s[left]);
                left++;
                count--;
            }
            max = Math.Max(max,count);
        }
        return max;
    }
}
