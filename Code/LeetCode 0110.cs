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
    public bool IsBalanced(TreeNode root) 
    {
        return Gethight(root)==-1 ? false : true;
    }

    public int Gethight(TreeNode root)
    {
        if(root==null)return 0;

        int leftB = Gethight(root.left);
        if(leftB==-1)return -1;
        
        int rightB = Gethight(root.right);
        if(rightB == -1)return -1;

        if(Math.Abs(rightB - leftB)>1)
        {
            return -1;
        }
        else
        {
            return 1+Math.Max(rightB,leftB);
        }
    }

}
