public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) 
    {
        Stack<int> stack = new Stack<int>();
        int[] res = new int[nums1.Length];
        Array.Fill(res , -1);

        if(nums1.Length == 0)return res;

        Dictionary<int,int> dc = new Dictionary<int, int>();//key元素 value下標

        for(int i = 0; i<nums1.Length; i++)
        {
            dc[nums1[i]] = i;
        }

        stack.Push(0);

        for(int i = 1; i<nums2.Length; i++)
        {
            if(nums2[i] < nums2[stack.Peek()])//當前元素 < 棧頂元素
            {
                stack.Push(i);
            }

            else if(nums2[i] == nums2[stack.Peek()])//當前元素 = 棧頂元素
            {
                stack.Push(i);
            }
            else
            {
                while(stack.Count > 0 && nums2[i] > nums2[stack.Peek()])//棧不為空 且 當前元素 > 棧頂元素
                {
                    if(dc.ContainsKey(nums2[stack.Peek()]))//棧頂的元素是否在字典裡
                    {
                        int index = dc[nums2[stack.Peek()]];//根據字典找到nums2[st.Pop()]的數在nums1下標
                        res[index] = nums2[i];//更新下標為index的數下一個比他大的數是甚麼
                    }
                    stack.Pop();//棧頂移除
                }
                stack.Push(i);//壓入新下標
            }
        }
        return res;
    }
}
