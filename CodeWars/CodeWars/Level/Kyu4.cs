using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Level
{
    public class Kyu4
    {
        public static bool ValidateSolution(int[][] board)
        {
            int[] validRow = new int[9];
            int[] validCol = new int[9];
            int[] validSquare = new int[9];

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board.Length; j++)
                {
                    validRow[j] = board[i][j];
                    validCol[j] = board[j][i];
                }
                if (!ValidSudokuArray(validRow) || !ValidSudokuArray(validCol))
                    return false;

                if (i % 3 == 0)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        for (int k = 0; k < 3; k++)
                        {
                            validSquare[i * 3 + j] = board[i + j][i + k];
                        }
                    }
                    if (!ValidSudokuArray(validSquare))
                        return false;
                }
            }

            return true;
        }

        public static bool ValidSudokuArray(int[] validated)
        {
            if (validated.Contains(0))
                return false;

            return validated.Distinct().Count() == 9;
        }
    }
}
