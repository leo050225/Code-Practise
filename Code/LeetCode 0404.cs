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
    public int SumOfLeftLeaves(TreeNode root) 
    {
        if(root==null)return 0;

        int leftSum  = SumOfLeftLeaves(root.left);//遞歸
        int rightSum = SumOfLeftLeaves(root.right);//遞歸
        if(root.left!=null && root.left.left==null && root.left.right==null)//判斷是否是左葉子
        {
            leftSum+=root.left.val;//是左葉子的話加入左邊點的總和
        }

        return leftSum+rightSum;//返回總和
    }
}
