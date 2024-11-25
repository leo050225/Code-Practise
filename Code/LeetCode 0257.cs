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
    public IList<string> BinaryTreePaths(TreeNode root) 
    {
        List<int> path = new List<int>();//儲存數字

        List<string> res = new List<string>();//儲存結果

        if(root == null) return res;//如果節點沒東西的話直接返回

        Traversal(root,path,res);//調用方法

        return res;//返回結果
    }

    public void Traversal(TreeNode node,List<int> path,List<String> res)
    {
        path.Add(node.val);//將該節點的數字記錄起來


        if(node.left==null && node.right==null)//如果是 葉節點
        {
            String sPath = "";//創建一個空的字串

            for(int i =0; i<path.Count-1;i++)
            {
                sPath += path[i].ToString();
                sPath += "->";
            }

            sPath += path[path.Count-1].ToString();//把最後一個數字加進來
            res.Add(sPath);//加入到res
            return;//返回
        }

        if(node.left != null)//如果左節點有東西的話 遞歸
        {
            Traversal(node.left,path,res);//遞歸
            path.RemoveAt(path.Count-1);//回朔 不然會出錯
        }

        if(node.right != null)//如果右節點有東西話 遞歸
        {
            Traversal(node.right,path,res);//遞歸
            path.RemoveAt(path.Count-1);//回朔 不然會出錯
        }
    }

    
}
