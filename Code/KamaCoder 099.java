import java.util.*;

public class Main 
{
    public static int[][] dir = {{0,1},{1,0},{-1,0},{0,-1}};//四個方向 右 下 上 左

    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);

        int m  = sc.nextInt();//列數
        int n  = sc.nextInt();//行數

        int[][] grid = new int[m][n];//陣列大小

        for(int i = 0; i< m; i++)
        {
            for(int j = 0; j<n; j++)
            {
                grid[i][j] = sc.nextInt();//陣列圖
            }
        }

        boolean[][] visited = new boolean[m][n];//紀錄是否訪問

        int ans = 0;//計算島嶼數量

        for(int i =0; i<m; i++)
        {
            for(int j = 0; j<n; j++)
            {
                if(!visited[i][j] && grid[i][j] ==1)//如果沒有訪問 且 是陸地
                {
                    ans++;
                    visited[i][j] = true;
                    dfs(visited, i, j, grid);//進行dfs搜索
                }
            }
        }
        System.out.println(ans);
    }
    
    public static void dfs(boolean[][] visited , int x , int y , int[][] grid)
    {
        for(int i = 0; i<4; i++)
        {
            int nextX = x + dir[i][0];//新的x座標
            int nextY = y + dir[i][1];//新的Y座標
            
            //邊界檢查
            if(nextY < 0 || nextX < 0 || nextX >= grid.length || nextY >= grid[0].length) continue;//跳過循環

            if(!visited[nextX][nextY] && grid[nextX][nextY] == 1)//沒有訪問過 且 是陸地
            {
                visited[nextX][nextY] = true;
                dfs(visited, nextX, nextY, grid);//繼續深度搜索
            }
        }
    }
}
