public class Solution 
{
    public string LongestCommonPrefix(string[] strs) 
    {
        string count = "";

        for(int i = 0;i<strs[0].Length;i++)
        {
            for(int j = 0;j<strs.Length;j++)
            {
                if(i>strs[j].Length-1 || strs[j][i] != strs[0][i])
                {
                    return count;
                }
            }
            count +=strs[0][i];
        }
        return count;
    }
}
