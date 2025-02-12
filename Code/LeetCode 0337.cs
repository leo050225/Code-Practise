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
    public int Rob(TreeNode root) 
    {
        int[] result = RobTree(root);

        return Math.Max(result[0], result[1]);//比較偷和不偷
    }
    
    private int[] RobTree(TreeNode cur)//0:不偷 1:偷
    {
        if(cur == null)return new int[] {0,0};

        int[] left = RobTree(cur.left);
        int[] right = RobTree(cur.right);

        int val1 = cur.val + left[0] + right[0];//偷cur

        int val2 = Math.Max(left[0],left[1]) + Math.Max(right[0] , right[1]);//不偷cur

        return new int[] {val2,val1};//回傳不偷和偷
    }
}
