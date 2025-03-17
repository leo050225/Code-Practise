public class Solution {
    public int[] NextGreaterElements(int[] nums) 
    {
        int[] res = new int[nums.Length];
        Array.Fill(res,-1);

        if(nums.Length==0)return res;

        Stack<int> stack = new Stack<int>();
        stack.Push(0);

        for(int i = 1; i<nums.Length * 2; i++)
        {
            if(nums[i % nums.Length] < nums[stack.Peek()])//新的小於目前棧頂的數
            {
                stack.Push(i % nums.Length);//壓入棧
            }
            else if(nums[i % nums.Length] == nums[stack.Peek()])//新的等於目前棧頂的數
            {
                stack.Push(i % nums.Length);//壓入棧
            }
            else
            {
                while(stack.Count != 0 && nums[i % nums.Length] > nums[stack.Peek()])//新的大於目前棧頂的數
                {
                    res[stack.Peek()] = nums[i % nums.Length];
                    stack.Pop();//移除
                }
                stack.Push(i % nums.Length);//壓入新的
            }
        }
        return res;
    }
}
