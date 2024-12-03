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
        //題目 二叉數裡面一定會有p和q
        if(root==null || root == p || root==q)return root;//如果空的樹直接返回 如果找到對應的值返回當前節點

        TreeNode left = LowestCommonAncestor(root.left, p,q);//左子樹遞歸
        TreeNode right  = LowestCommonAncestor(root.right, p,q);//右子樹遞歸

        if(left != null && right != null)return root;
        // 如果 p 和 q 分别位於當前節點的左右子樹，則當前節點是它們的最近公共祖先

        if(left == null && right!=null)return right;
        // 如果左子樹返回 null，說明 p 和 q 都在右子樹中，返回右子樹的结果

        if(left != null && right==null)return left;
        // 如果右子樹返回 null，說明 p 和 q 都在左子樹中，返回左子樹的结果

        return null;// 如果左右子樹都為 null，則返回 null
    }
}
