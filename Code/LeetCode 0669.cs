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
    public TreeNode TrimBST(TreeNode root, int low, int high) 
    {
        if(root == null)return null;//返回空

        if(root.val < low)
        {
            return TrimBST(root.right,low,high);//只拿大於邊界值右子樹
        }
        
        if(root.val > high)
        {
            return TrimBST(root.left,low,high);//只拿小於邊界值的左子樹
        }

        root.left = TrimBST(root.left,low,high);//左子樹遞歸
        root.right = TrimBST(root.right,low,high);//右子數遞歸

        return root;//返回
    }
}
