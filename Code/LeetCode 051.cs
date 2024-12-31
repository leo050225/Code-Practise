public class Solution {
    public IList<IList<string>> SolveNQueens(int n) 
    {
        char[][] chessBoard = new char[n][];//創建n列的棋盤的棋盤

        for(int i = 0; i<n;i++)
        {
            chessBoard[i] = new char[n];//每一列創建n行
            for(int j = 0; j<n; j++)
            {
                chessBoard[i][j] = '.';//都先附上空格
            }
        }
        BackTracking(n,0,chessBoard);//調用

        return res;//返回
        
    }

    public List<IList<string>> res = new();//創建集合

    public void BackTracking(int n , int row,char[][] chessBoard)
    {
        if(row == n)
        {
            res.Add(chessBoard.Select(x => new string(x)).ToList());//char轉換成List<string>
            return;//返回
        }

        for(int col = 0; col<n;col++)
        {
            if(IsValid(row , col , chessBoard, n))//驗證符合皇后的規則 不能同行 不能同列 不能同斜線
            {
                chessBoard[row][col] = 'Q';//放置皇后

                BackTracking(n,row+1,chessBoard);//調用

                chessBoard[row][col] = '.';//把皇后變成空格
            }
        }
    }

    public bool IsValid(int row,int col,char[][] chessBoard, int n)
    {
        //檢查列    .Q.Q.
        for(int i = 0; i<row;i++)
        {
            if(chessBoard[i][col] == 'Q')return false;
        }

        //檢查45度角是否有皇后
        //..Q..
        //...Q.
        for(int i = row -1,j = col - 1 ;i >= 0 && j >= 0;i--,j--)
        {
            if(chessBoard[i][j]=='Q')return false;
        }

        //檢查135度角是否有皇后
        //...Q.
        //..Q..
        for(int i =row -1,j = col+1;i >=0&& j<n; i--,j++)
        {
            if(chessBoard[i][j] == 'Q')return false;
        }

        return true;//符合規則 返回true
    }
}
