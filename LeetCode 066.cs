public class Solution {
    public int[] PlusOne(int[] digits) 
    {
        int len = digits.Length;

        for(int i = len-1 ; i >=0 ; i--)
        {
            digits[i]++;
            digits[i] %= 10;

            if(digits[i]!=0)//如果沒有進位就直接返還
            {
                return digits;
            }
        }

        int[] ans = new int[len+1];//如果都是9直接進位
        ans[0] = 1;
        return ans;
    }
}
