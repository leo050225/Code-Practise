public class Solution {
    public bool LemonadeChange(int[] bills) 
    {
        int five = 0;
        int ten = 0;
        int twenty = 0;

        foreach(var bill in bills)//分別判斷每種付款情形
        {
            if(bill==5) five++;
            if(bill==10)
            {
                if(five==0)return false;
                ten++;
                five--;
            }
            if(bill==20)
            {
                if(ten > 0 && five > 0)
                {
                    ten--;
                    five--;
                    twenty++;
                }
                else if(five>=3)
                {
                    five-=3;
                    twenty++;
                }
                else return false;
            }
        }    
        return true;
    }
}
