using System;

namespace _07.Pawn_Wars
{
    class Program
    {
        static void Main(string[] args)
        {

            char[,] board = new char[8, 8];
            int whiteRow = 0;
            int whiteCol = 0;
            int blackRow = 0;
            int blackCol = 0;
            bool IsWhiteTurn = true;

            for (int row = 0; row < board.GetLength(0); row++)
            {
                string rowInfo = Console.ReadLine();

                for (int col = 0; col < board.GetLength(0); col++)
                {
                    board[row, col] = rowInfo[col];
                    if (rowInfo[col] == 'w')
                    {
                        whiteRow = row;
                        whiteCol = col;
                    }
                    if (rowInfo[col] == 'b')
                    {
                        blackRow = row;
                        blackCol = col;
                    }
                }
            }

            while (true)
            {

                if (IsWhiteTurn)
                {
                    board[whiteRow, whiteCol] = '-';
                    whiteRow--;

                    if (IsInRange(board, whiteRow, whiteCol - 1) && board[whiteRow, whiteCol - 1] == 'b'
                        || IsInRange(board, whiteRow, whiteCol + 1) && board[whiteRow, whiteCol + 1] == 'b')
                    {
                        board[blackRow, blackCol] = 'w';
                        var leftSideB = 8 - blackRow;
                        var right = 97 + blackCol;
                        Console.WriteLine($"Game over! White capture on {Convert.ToChar(right)}{leftSideB}.");
                        break;
                    }
                    if (whiteRow == 0)
                    {
                        board[whiteRow, whiteCol] = 'Q';
                        var leftSideB = 8 - whiteRow;
                        var right = 97 + whiteCol;
                        Console.WriteLine($"Game over! White pawn is promoted to a queen at {Convert.ToChar(right)}{leftSideB}.");
                        break;
                    }

                    board[whiteRow, whiteCol] = 'w';
                    IsWhiteTurn = false;
                }
                else
                {
                    board[blackRow, blackCol] = '-';
                    blackRow++;

                    if (IsInRange(board, blackRow, blackCol - 1) && board[blackRow, blackCol - 1] == 'w'
                        || IsInRange(board, blackRow, blackCol + 1) && board[blackRow, blackCol + 1] == 'w')
                    {
                        board[whiteRow, whiteCol] = 'b';
                        var ranks = 8 - whiteRow;
                        var columns = 97 + whiteCol;
                        Console.WriteLine($"Game over! Black capture on {Convert.ToChar(columns)}{ranks}.");
                        break;
                    }
                    if (blackRow == board.GetLength(0) - 1)
                    {
                        board[blackRow, blackCol] = 'Q';
                        var ranks = 8 - blackRow;
                        var columns = 97 + blackCol;
                        Console.WriteLine($"Game over! Black pawn is promoted to a queen at {Convert.ToChar(columns)}{ranks}.");
                        break;
                    }

                    board[blackRow, blackCol] = 'b';
                    IsWhiteTurn = true;
                }
            }

            //PrintMatrix(board);
        }
        private static bool IsInRange(char[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
        }

        private static void PrintMatrix(char[,] field)
        {
            Console.WriteLine();
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    Console.Write(field[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}