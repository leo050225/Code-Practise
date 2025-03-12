public class Solution {
    public int[] DailyTemperatures(int[] temperatures) 
    {
        int lens = temperatures.Length;
        int[] res = new int[lens];

        Stack<int> stack = new Stack<int>();
        stack.Push(0);//壓入棧底

        for(int i = 1; i<lens; i++)
        {
            if(temperatures[i] < temperatures[stack.Peek()])//新的小於目前棧頂的數
            {
                stack.Push(i);//壓入棧
            }
            else
            {
                //移出棧
                //棧不是空 新的大於目前棧頂的數
                while(stack.Count != 0 && temperatures[i] > temperatures[stack.Peek()])
                {
                    res[stack.Peek()] = i - stack.Peek();//棧頂的下標 目前天數 - 下標的天數
                    stack.Pop();//移除棧頂
                }

                stack.Push(i);//新的壓入棧
            }
        }
        return res;//返回數組
    }
}
