public class Solution {
    public int EvalRPN(string[] tokens) 
    {
        Stack<int> st = new Stack<int>();
        int num;

        foreach(string s in tokens)
        {
            if(int.TryParse(s,out num))
            {
                st.Push(num);
            }
            else
            {
                int num1 = st.Pop();
                int num2 = st.Pop();

                switch(s)
                {
                    case "+":
                        st.Push(num1+num2);
                        break;
                    case "-":
                        st.Push(num2-num1);
                        break;
                    case "*":
                        st.Push(num1*num2);
                        break;
                    case "/":
                        st.Push(num2/num1);
                        break;
                    default:
                        break;
                }
            }
        }
        return st.Pop();
    }
}
