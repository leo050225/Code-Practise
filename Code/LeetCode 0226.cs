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
    public TreeNode InvertTree(TreeNode root) 
    {
        if(root == null)return root;//沒有節點的話返回根結點

        (root.right,root.left) = (root.left,root.right);//左右節點互換

        InvertTree(root.left);//遞歸調用
        InvertTree(root.right);//遞歸調用

        return root;
    }
}
