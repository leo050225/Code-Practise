public class Solution {
    public bool IsHappy(int n) 
    {
        HashSet<int> set = new HashSet<int>();
        while(n!=1 && !set.Contains(n))
        {
            set.Add(n);
            n = getsum(n);
        }
        return n==1;
    }


    private int getsum(int n )
    {
        int sum = 0;
        while(n>0)
        {
            sum+=(n%10)*(n%10);
            n/=10;
        }
        return sum;
    }
}
