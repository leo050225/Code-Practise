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
public class Solution 
{
    //累加樹
    //每個節點的值是原來節點的值加上所有大於他的值
    //此提示二叉搜索樹
    //右節點 -> 根節點 -> 左節點

    int pre = 0;//儲存所有比目前節點還大的值總和

    public TreeNode ConvertBST(TreeNode root) 
    {
        if(root == null) return null;//返回空

        ConvertBST(root.right);//右子樹遞歸

        root.val += pre;//當前節點加上所有大於他的值

        pre = root.val;//更新所有大於他的值

        ConvertBST(root.left);//左子樹遞歸

        return root;//返回
    }
}
