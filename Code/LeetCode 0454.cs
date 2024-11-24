public class Solution {
    public int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4) 
    {
        Dictionary<int,int> dic = new Dictionary<int, int>();

        foreach(var i in nums1)//遍歷nums1
        {
            foreach(var j in nums2)//遍歷nums2
            {
                int sum = i+j;//nums1+nums2的所有和

                if(dic.ContainsKey(sum))//如果再dic裡有這個和 這個和的數字+1
                {
                    dic[sum]++;
                }
                else//沒有的話新增一個位置
                {
                    dic.Add(sum,1);
                }
            }
        }

        int res = 0;

        foreach(var a in nums3)//遍歷nums3
        {
            foreach(var b in nums4)//遍歷nums4
            {
                int sum = a+b;//nums3+nums4的所有和

                if(dic.TryGetValue(-sum,out var result))//dic裡找到key 並返回value
                {
                    res+=result;//如果有可以相加等於0的 返回那個數字出現的次數
                }
            }
        }
        return res;//返回總共的次數
    }
}
