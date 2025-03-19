public class Solution {
    public int LargestRectangleArea(int[] heights) 
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(0);

        //前後+0 防止數組本身是升序或是降序
        int[] newHeights = new int[heights.Length+2];
        newHeights[0] = 0;
        newHeights[newHeights.Length-1] = 0;
        for(int i = 0; i<heights.Length; i++)
        {
            newHeights[i+1] = heights[i];
        }    
        heights = newHeights;

        int result = 0;

        for(int i = 1; i < heights.Length; i++)
        {
            if(heights[i] >= heights[stack.Peek()])
            {
                stack.Push(i);
            }
            else
            {
                while(heights[i] < heights[stack.Peek()])
                //不會更新目前的下標 所以面積不會只算一行
                {
                    int mid = stack.Pop();

                    int left = stack.Peek();

                    int h = heights[mid];
                    int w = i - left - 1;
                    result = Math.Max(result , h*w);//面積
                }
                stack.Push(i);
            }
        }
        return result;
    }
}
