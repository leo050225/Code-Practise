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
    public TreeNode DeleteNode(TreeNode root, int key) 
    {
        if(root == null)return null;//返回空

        if(key==root.val)
        {
            if(root.left == null && root.right == null) return null;//返回空

            if(root.left != null && root.right==null)return root.left;//返回左子樹

            if(root.left == null && root.right != null)return root.right;//返回右子樹

            if(root.left!=null && root.right !=null)
            {
                TreeNode leftNode  = root.right;//指向根節點的右子樹

                while(leftNode.left != null)//循環 直到最左邊的節點
                {
                    leftNode = leftNode.left;//指向最左邊的位置
                } 
                leftNode.left = root.left;//在最左邊的位置 新增根節點的左子樹
                return root.right;//用根節點的右子樹 取代 根節點
            }
        }

        if(root.val > key )root.left = DeleteNode(root.left, key);//遞歸
        if(root.val < key)root.right = DeleteNode(root.right, key);//遞歸

        return root;//返回
    }
}
