public class Solution {
    public int Trap(int[] height) 
    {
        if(height.Length <= 2)return 0;
        
        Stack<int> stack = new Stack<int>();
        stack.Push(0);

        int sum = 0;//容量總和

        for(int i = 1; i<height.Length; i++)
        {
            int stackTop = stack.Peek();
            if(height[i] < height[stackTop])
            {
                stack.Push(i);
            }
            else if(height[i] == height[stackTop])
            {
                //因相同高度
                stack.Pop();
                stack.Push(i);
            }
            else
            {
                while(stack.Count != 0 && height[i] > height[stackTop])
                {
                    int mid = stack.Pop();//移出

                    if(stack.Count != 0)
                    {
                        int left = stack.Peek();

                        int h = Math.Min(height[left] , height[i]) - height[mid];//min(左標,右邊) - 底部高度
                        int w = i - left - 1;//寬  右邊下標 - 左邊下標 - 1 因只求中間
                        int hold = h * w;//雨水容量

                        if(hold > 0) sum+= hold;

                        stackTop = stack.Peek();//更新棧頂的數值(更新左邊)
                    }
                }
                
                stack.Push(i);//壓入棧
            }
        }
        return sum;
    }
}
