public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) 
    {
        myDeueue windoe = new myDeueue();
        List<int> res = new List<int>();

        for(int i =0;i<k;i++)
        {
            windoe.Enqueue(nums[i]);
        }
        res.Add(windoe.Max());

        for(int i =k;i<nums.Length;i++)
        {
            windoe.Deueue(nums[i-k]);
            windoe.Enqueue(nums[i]);
            res.Add(windoe.Max());
        }
        return res.ToArray();
    }
}

class myDeueue()
{
    public LinkedList<int> linkedlist = new LinkedList<int>();

    public void Deueue(int n)
    {
        if(linkedlist.First.Value==n)
        {
            linkedlist.Remove(linkedlist.First.Value);
        }
    }

    public void Enqueue(int n)
    {
        while(linkedlist.Count>0 && linkedlist.Last.Value<n)
        {
            linkedlist.Remove(linkedlist.Last.Value);
        }
        linkedlist.AddLast(n);
    }

    public int Max()
    {
        return linkedlist.First.Value;
    }
}
