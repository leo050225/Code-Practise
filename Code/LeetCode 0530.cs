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
    public int GetMinimumDifference(TreeNode root) 
    {
        Trav(root);//調用方法

        //x是當前的值 i是索引
        //SelectMany會有一個鋪平的集合 會遍歷res裡面的數值和索引(x,i)
        //然後會再找一個集合用遍歷 res.Skip(i+1).Select  裡面的數值是y
        //然後用x和y帶進去Math.Abs(x-y) 算出來的結果會被SelectMany儲存
        //最後用res.SelectMany.Min() 取出SelectMany裡面的最小值 返回
        return res.SelectMany((x,i) => res.Skip(i+1).Select(y => Math.Abs(x-y))).Min();
    }

    public List<int> res = new List<int>();//創建一個List

    public void Trav(TreeNode root)
    {
        if(root==null)return;//空就返回
        Trav(root.left);//遞歸左子樹
        res.Add(root.val);//加入List
        Trav(root.right);//遞歸右子樹
    }
}
