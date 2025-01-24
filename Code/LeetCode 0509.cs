public class Solution {
    public int Fib(int n) 
    {
        if(n ==0)return 0;
        if(n ==1)return 1;
        
        //初始化數組
        int[] res = new int[n];
        res[0] = 0;
        res[1] = 1;

        for(int i = 2; i<res.Length; i++)//填滿數組
        {
            res[i] = res[i-1]+res[i-2];
        }

        return res[n-1]+res[n-2];
    }
}
