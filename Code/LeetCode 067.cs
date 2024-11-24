public class Solution {
    public string AddBinary(string a, string b) 
    {
        StringBuilder sb = new StringBuilder();

        int index1 = a.Length -1;
        int index2 = b.Length -1;
        int carry = 0;

        while(index1>=0 || index2>=0 || carry !=0)
        {
            int ditit1 = index1>=0 ? a[index1] - '0':0;
            int ditit2 = index2>=0 ? b[index2] - '0':0;
            int sum = ditit1+ditit2+carry;

            sb.Append(sum%2);
            carry = sum/2;
            index1--;
            index2--;
        }

        StringBuilder sb2 = new StringBuilder();
        for(int i = sb.Length - 1 ; i>=0 ; i--)
        {
            sb2.Append(sb[i]);
        }

        return sb2.ToString();
    }
}
