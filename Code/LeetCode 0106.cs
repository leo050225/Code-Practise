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
    //inorder 中序遍歷   左子樹 -> 根節點 -> 右子樹 左9 : 根3 : 右15,20,7
    //postorder 後序遍歷 左子樹 -> 右子樹 -> 根節點 左9 : 右15,7,20 : 根3
    public TreeNode BuildTree(int[] inorder, int[] postorder) 
    {
        if(inorder.Length==0 || postorder.Length==0)return null;//沒有數字的話返回null

        int rootValue = postorder.Last();//確定這棵樹的根結點 後續遍歷的最後一數

        TreeNode root = new TreeNode(rootValue);//創立新的二叉樹根節點

        int delimiterIndex = Array.IndexOf(inorder, rootValue);//在中序遍歷中找到根節點的數的索引
        //這案例 indoor的根節點索引是1

        //創立左子樹 
        //Take: 第一個元素起算到參數設定的數量為止的元素的集合為結果集合
        //兩者左子樹都在最前面 所以直接用inorder的根節點索引當數量
        root.left = BuildTree(inorder.Take(delimiterIndex).ToArray() , postorder.Take(delimiterIndex).ToArray());//遞歸

        //Skip: 由集合的第一個元素開始記數，到達指定的數量為止的元素都忽略不算在結果集合中
        //inorder右子樹在最後面 所以要跳過[ 根索引+1 ]的數量  postorder的右子樹在中間 所以要跳過左子樹 然後在取從前面[ 總長度 - 索引 - 1 ]數量的數字
        root.right = BuildTree(inorder.Skip(delimiterIndex + 1).ToArray() , postorder.Skip(delimiterIndex).Take(inorder.Length - delimiterIndex - 1).ToArray());//遞歸

        return root;
    }
}
