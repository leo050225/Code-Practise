public class Solution {
    public int[] TopKFrequent(int[] nums, int k) 
    {
        Dictionary<int,int> dic = new Dictionary<int, int>();

        for(int i = 0 ; i<nums.Length;i++)
        {
            if(dic.ContainsKey(nums[i]))
            {
                dic[nums[i]]++;
            }
            else
            {
                dic.Add(nums[i],1);
            }
        }

        PriorityQueue<int,int> pq = new PriorityQueue<int, int>();

        foreach(var num in dic)
        {
            pq.Enqueue(num.Key,num.Value);
            if(pq.Count >k)
            {
                pq.Dequeue();
            }
        }

        int[] res = new int[k];
        for(int i = k-1;i>=0;i--)
        {
            res[i] = pq.Dequeue();
        }
        return res;
    }
}
