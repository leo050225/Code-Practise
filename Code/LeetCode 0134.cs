public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) 
    {
        int curSum = 0;//目前消耗剩餘
        int totalSum = 0;//整體消耗
        int start = 0;//起始位置

        for(int i =0; i<gas.Length; i++)
        {
            curSum += gas[i] - cost[i];
            totalSum += gas[i] - cost[i];

            if(curSum < 0)
            {
                start = i + 1;//起始位置更新
                curSum = 0;
            }
        }

        if(totalSum < 0) return -1;

        return start;
    }
}
