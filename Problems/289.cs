using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _289
    {
        public void GameOfLife(int[][] board)
        {
            for (int i = 0; i < board.Length; i++)
            {
                for(int j = 0; j < board[i].Length; j++)
                {
                    int n = CountNeighborsWithOne(board, i, j, board.Length, board[i].Length);
                    if (board[i][j] == 1 && (n < 2 || n > 3)) board[i][j] = 0; 
                    else if (board[i][j] == 0 && n == 3) board[i][j] = 1;
                }
            }
        }

        private static int CountNeighborsWithOne(int[][] board, int row, int col, int rows, int cols)
        {
            int[] rowOffset = { -1, -1, -1, 0, 0, 1, 1, 1 };
            int[] colOffset = { -1, 0, 1, -1, 1, -1, 0, 1 };

            int count = 0;
            for (int k = 0; k < 8; k++)
            {
                int newRow = row + rowOffset[k];
                int newCol = col + colOffset[k];
                if (IsValidCell(newRow, newCol, rows, cols) && board[newRow][newCol] == 1)
                {
                    count++;
                }
            }
            return count;
        }
        private static bool IsValidCell(int row, int col, int rows, int cols)
        {
            return row >= 0 && row < rows && col >= 0 && col < cols;
        }
    }
}
