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
    public TreeNode MergeTrees(TreeNode root1, TreeNode root2) 
    {
        if(root1==null)return root2;//如果為空返回另一棵樹
        if(root2==null)return root1;//如果為空返回另一棵樹

        root1.val+=root2.val;//兩顆二叉樹的節點相加

        root1.left = MergeTrees(root1.left,root2.left);//左子樹遞歸
        root1.right = MergeTrees(root1.right,root2.right);//右子樹遞歸

        return root1;//返回
    }
}
