public class Solution {
    public bool UniqueOccurrences(int[] arr) 
    {
        int[] count = new int[2001];

        for(int i = 0; i<arr.Length; i++)
        {
            count[arr[i]+1000]++;
        }    

        bool[] flag = new bool[1002];

        for(int i = 0; i<=2000; i++)
        {
            if(count[i]>0)
            {
                if(flag[count[i]] == false)
                {
                    flag[count[i]] = true;
                }
                else
                {
                    return false;
                }
            }
        }
        return true;
    }
}
