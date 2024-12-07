/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode SortedArrayToBST(int[] nums) 
    {
        return Traversal(nums,0,nums.Length-1);//調用方法
    }
    
    public TreeNode Traversal(int[]nums,int left,int right)
    {
        if(left>right)return null;//返回空

        int mid = left + ((right - left)/2);//防止都是int最大 相加溢出

        TreeNode node = new TreeNode(nums[mid]);//創建節點

        node.left = Traversal(nums,left,mid-1);//左子樹遞歸
        node.right = Traversal(nums,mid+1,right);//右子樹遞歸

        return node;//返回
    }
}
