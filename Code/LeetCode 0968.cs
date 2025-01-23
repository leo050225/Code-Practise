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
    public int MinCameraCover(TreeNode root) 
    {
        if(Traversal(root) == 0) res++;//如果頭節點是無覆蓋 在加一個攝影機
        return res;
    }

    public int res =0;

    public int Traversal(TreeNode cur)//後序遍歷
    {
        if(cur == null)return 2;//只能返回有覆蓋

        int left = Traversal(cur.left);
        int right = Traversal(cur.right);

        if(left ==2 && right ==2)return 0;//無覆蓋

        else if(left == 0 || right == 0)//子節點有無覆蓋
        {
            res++;
            return 1;//有攝像頭
        }
        else return 2;//有被覆蓋
    }
}
