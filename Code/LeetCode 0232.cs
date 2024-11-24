public class MyStack 
{

    Queue<int> q1;
    Queue<int> q2;

    public MyStack() 
    {
        q1 = new Queue<int>();
        q2 = new Queue<int>();
    }
    
    public void Push(int x) 
    {
        while(q1.Count !=0)
        {
            q2.Enqueue(q1.Dequeue());
        }
    }
    
    public int Pop()//移除并返回栈顶元素
    {
        return q1.Count > 0 ? q1.Dequeue() : -1;
    }
    
    public int Top()//返回栈顶元素
    {
        return q1.Count>0 ? q1.Peek() : -1;
    }
    
    public bool Empty() 
    {
        return q1.Count == 0; 
    }

}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */
