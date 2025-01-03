public class Solution {
    public void SolveSudoku(char[][] board) 
    {
        BackTracking(board);
    }

    public bool BackTracking(char[][] board)
    {
        for(int i =0; i<board.Length; i++)//遍歷行
        {
            for(int j =0; j<board[0].Length; j++)//遍歷列
            {
                if(board[i][j] != '.')continue;//如果已經有數字跳過當前位置

                for(char k = '1' ; k <= '9' ; k++)//判斷當前位置適合1~9哪個數字
                {
                    if(IsValid(board,i,j,k))
                    {
                        board[i][j] = k;//放入k
                        if(BackTracking(board)) return true;
                        board[i][j] = '.';//回朔
                    }
                }
                return false;//9個數字都試完 都不行
            }
        }
        return true;//遍歷完沒有false 找到合適位置
    }

    public bool IsValid(char[][] board, int row ,int col, char val)
    {
        for(int i = 0 ; i < 9 ; i++)//判斷行裡是否有重複
        {
            if(board[i][col] == val) return false;
        }
        
        for(int i =0; i<9; i++)//判斷列裡是否有重複
        {
            if(board[row][i] == val) return false;
        }

        int startRow = (row / 3) *3;//起始位置
        int startCol = (col / 3) *3;//起始位置

        for(int i = startRow; i < startRow+3; i++)//檢查9宮格內有沒有重複
        {
            for(int j = startCol; j < startCol+3 ; j++)
            {
                if(board[i][j] == val)return false;
            }
        }
        return true;//沒有重複的話返回
    }
}
