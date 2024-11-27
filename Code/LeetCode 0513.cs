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
    int maxdepth = -1;
    int res = 0;
    public int FindBottomLeftValue(TreeNode root) 
    {
        Trav(root,0);    
        return res;
    }

    public void Trav(TreeNode root,int depth)
    {
        if(root.left==null && root.right==null)
        {
            if(depth>maxdepth)//目前深度比紀錄的最深深度還深的話 更新深度和數值
            {
                maxdepth = depth;
                res = root.val;
            }
            return;
        }

        //會先去偵測最左邊的數值 就算遍歷到右邊也不會覆蓋 因為深度一樣
        if(root.left!=null)
        {
            Trav(root.left,depth+1);//往下就深度+1
        }

        if(root.right!=null)
        {
            Trav(root.right,depth+1);//往下就深度+1
        }
        return;
    }
}
