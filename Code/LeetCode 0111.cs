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
    public int MinDepth(TreeNode root) 
    {
        if(root==null)return 0;//都沒有的話返回0

        int right = MinDepth(root.right);//遞歸
        int left = MinDepth(root.left);//遞歸

        if(root.left==null&&root.right!=null)//左邊沒東西 右邊有東西的話 只返回右邊
        {
            return 1+right;
        }
        else if(root.left!=null&&root.right==null)//左邊有東西 右邊沒東西的話 只返回左邊
        {
            return 1+left;
        }

        return 1+Math.Min(left,right);//返回
    }
}
