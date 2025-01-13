public class Solution {
    public int Candy(int[] ratings) 
    {
        int[] candies = new int[ratings.Length];

        for(int i = 0; i < candies.Length; i++)//每人先發一顆糖果
        {
            candies[i] = 1;
        }

        for(int i =1; i<ratings.Length; i++)//從前面開始 左邊分數<右邊分數 
        {
            if(ratings[i] > ratings[i - 1])
            {
                candies[i] = candies[i - 1] + 1;
            }
        }

        for(int i = ratings.Length -2; i >= 0; i--)//從後面開始 左邊分數>後面分數
        {
            if(ratings[i] > ratings[i+1])
            {
                candies[i] = Math.Max(candies[i], candies[i + 1] + 1);
            }
        }
        return candies.Sum();//糖果總和
    }
}
