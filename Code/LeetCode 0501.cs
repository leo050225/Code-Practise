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
    public List<int> res = new List<int>();//儲存的列表
    public int count;//目前數字的出現數字
    public int maxCount;//最大出現次數
    public TreeNode pre;//儲存上一個節點的值

    public int[] FindMode(TreeNode root) 
    {
        SearchBST(root);//調用方法
        return res.ToArray();
    }

    public void SearchBST(TreeNode root)
    {
        if(root==null)return;//二叉樹空的話就返回

        SearchBST(root.left);//左子樹遞歸

        if(pre==null) count = 1;//初始化
        else if(pre.val == root.val) count++;//數值重複的話自增
        else count = 1;//換數字的話count初始化

        pre = root;//儲存節點

        if(count == maxCount)//如果跟眾數次數一樣的話 加進列表裡
        {
            res.Add(root.val);//加進列表
        }
        else if(count > maxCount)//如果超越最大次數的話 更新列表
        {
            res.Clear();//清除列表
            res.Add(root.val);//加入新的眾數
            maxCount = count;//更新最大次數
        }
        SearchBST(root.right);//右子樹遞歸
    }
}
