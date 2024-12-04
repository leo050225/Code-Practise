/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) 
    {
        //有序的二叉樹
        if(root.val > p.val && root.val > q.val) //比根節點小的話往左子樹
        return LowestCommonAncestor(root.left,p,q);

        if(root.val < p.val && root.val < q.val) //比根節點小的話往右子樹
        return LowestCommonAncestor(root.right, p ,q);

        return root;//返回當前節點
        
    }
}
