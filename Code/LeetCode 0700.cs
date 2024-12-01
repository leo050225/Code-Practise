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
    public TreeNode SearchBST(TreeNode root, int val)
    {
        //二叉搜索樹 左節點 < 根節點     右節點 > 根節點
        if(root==null ||root.val==val)return root;//為空或是符合val 返回root

        if(root.val>val) return SearchBST(root.left,val);//如果節點大於目標值 遞歸左子樹
        if(root.val<val) return SearchBST(root.right,val);//如果節點小於目標值 遞歸右子樹

        return null;//返回
    }
}
