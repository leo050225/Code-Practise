public class Solution {
    public bool IsValid(string s) 
    {
        int len = s.Length;

        if(len%2==1)return false;//如果長度是奇數 沒有對稱

        var st = new Stack<int>();

        for(int i =0; i<len; i++)
        {
            if(s[i]=='(')
            {
                st.Push(')');
            }
            else if(s[i]=='{')
            {
                st.Push('}');
            }
            else if(s[i]=='[')
            {
                st.Push(']');
            }
            else if(st.Count==0 || st.Pop()!=s[i])//如果棧裡沒東西 或是 消除返回的括號不等於棧裡現在的括號
            {
                return false;
            }
        }

        if(st.Count>0)//如果還有剩返回false
        {
            return false;
        }
        else//如果沒有返回true
        {
            return true;
        }
    }
}
