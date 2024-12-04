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
    public TreeNode InsertIntoBST(TreeNode root, int val) 
    {
        if(root == null) return new TreeNode(val);//如果找到了位置 就新增一個節點然後返回

        if(root.val > val) root.left = InsertIntoBST(root.left,val);//如果小於根節點 左子樹遞歸
        if(root.val < val) root.right = InsertIntoBST(root.right,val);//如果大於根結點 右子樹遞歸

        return root;//返回當前節點
    }
}
