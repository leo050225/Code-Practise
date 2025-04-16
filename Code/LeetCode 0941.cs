public class Solution {
    public bool ValidMountainArray(int[] arr) 
    {
        if(arr.Length<3)return false;
        int left = 0;
        int rigth = arr.Length-1;

        while(left < arr.Length-1 && arr[left] < arr[left+1])left++;

        while(rigth > 0 && arr[rigth] < arr[rigth-1])rigth--;

        if(left == rigth && left!=arr.Length-1&& rigth!=0)return true;
        
        return false;
    }
}
