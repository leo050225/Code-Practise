public class Solution {
    public int MaxProfit(int[] prices) 
    {
        int res = 0;

        for(int i = 0 ; i<prices.Length-1 ; i++)
        {
            res+=Math.Max(0,prices[i+1] - prices[i]);//有利潤的才加入計算
        }
        return res;
    }
}
