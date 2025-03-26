import java.util.*;

public class Main 
{
    static List<List<Integer>> result = new ArrayList<>();//收集符合條件的路徑
    static List<Integer> path = new ArrayList<>();//1~終點的路徑

    public static void dfs(int[][] graph , int x , int n)
    {
        if(x == n)//當前遍歷節點X 到達終點n
        {
            result.add(new ArrayList<>(path));//把path加入result
            return;
        }

        for(int i = 1; i<=n; i++)//遍歷節點x連接的所有節點
        {
            if(graph[x][i] == 1)//找到 x連結的節點
            {
                path.add(i);//節點加入路徑
                dfs(graph , i , n);//遞歸
                path.remove(path.size()-1);//回朔
            }
        }
    }

    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);

        int n = sc.nextInt();//節點數
        int m = sc.nextInt();//邊數

        int[][] graph = new int[n+1][n+1];//節點1~n

        for(int i = 0; i<m; i++)
        {
            int s = sc.nextInt();
            int t = sc.nextInt();

            graph[s][t] = 1;//節點s和t之間有路徑
        }

        path.add(1);
        dfs(graph , 1 , n);//圖 當前起點 終點

        if(result.isEmpty())System.out.println(-1);//沒有任何路徑

        for(List<Integer> pa : result)//輸出
        {
            for(int i = 0; i<pa.size() - 1; i++)
            {
                System.out.print(pa.get(i) + " ");
            }
            System.out.println(pa.get(pa.size() - 1));
        }
    }
}
