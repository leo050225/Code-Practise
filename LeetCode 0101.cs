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
    public bool IsSymmetric(TreeNode root) 
    {
        if(root==null)return false;

        return compare(root.left,root.right);
    }

    public bool compare(TreeNode left,TreeNode right)
    {
        if(left==null&&right!=null)return false;
        else if(left!=null&&right==null)return false;
        else if(left==null&&right==null) return true;
        else if(right.val!=left.val)return false;

        var outside = compare(left.left,right.right);
        var inside = compare(left.right,right.left);

        return outside&&inside;
    }
}
