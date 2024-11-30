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
    public TreeNode ConstructMaximumBinaryTree(int[] nums) 
    {
        if(nums.Length==0)return null;

        int rootValue = nums.Max();//找到最大值當根結點

        TreeNode root = new TreeNode(rootValue);//用跟節點創建樹

        int rootIndex = Array.IndexOf(nums,rootValue);//找到跟節點的值在數組裡的位置

        root.left =  ConstructMaximumBinaryTree(nums.Take(rootIndex).ToArray());//左子樹遞歸

        root.right  = ConstructMaximumBinaryTree(nums.Skip(rootIndex+1).ToArray());//右子樹遞歸

        return root;//返回
    }
}
