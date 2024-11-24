public class Solution {
    public string ReverseStr(string s, int k) 
    {
        Span<char> span = s.ToCharArray().AsSpan();

        for(int i =0; i<s.Length; i+=2*k)
        {
            span[i+k<s.Length ? i..(i+k) : i..].Reverse();
        }
        return span.ToString();
    }
}
