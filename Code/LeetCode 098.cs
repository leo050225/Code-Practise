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
    public bool IsValidBST(TreeNode root) 
    {
        //採用中序遍歷 左 -> 根 -> 右
        if(root==null)return true;//沒東西返回

        bool left = IsValidBST(root.left);//先進入左邊節點
        
        //檢查是否為BST
        if(root.val>val) val = root.val;//是的話 更新val數
        else return false;//不是返回false

        //當目前跟節點的左節點看完後會換自己跟節點 然後再進入右節點
        bool right = IsValidBST(root.right);//進入右邊節點
        
        return left && right;//是否兩邊都是BST
    }
    public long val = long.MinValue;
    
    //假設這棵樹是[4,2,6,1,3,5,7]
    //處理節點順序 1 -> 2 -> 3 -> 4 -> 5 -> 6 -> 7
}
