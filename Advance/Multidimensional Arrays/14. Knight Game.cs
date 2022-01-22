using System;

namespace _14._Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int boardSize = int.Parse(Console.ReadLine());
            char[,] chessBoard = ReadBoard(boardSize, boardSize);
            int attackedKnights = 0;
            while (true)
            {
                int maxAttack = 0;
                int rows = 0;
                int cols = 0;
                for (int row = 0; row < chessBoard.GetLength(0); row++)
                {
                    for (int col = 0; col < chessBoard.GetLength(1); col++)
                    {
                        if (chessBoard[row, col] == 'K') ;
                        {
                            int currAttack = 0;
                            //upLeft, upRight
                            if (IsValid(chessBoard, row - 2, col - 1) && chessBoard[row - 2, col - 1] == 'K')
                            {
                                currAttack++;
                            }
                            if (IsValid(chessBoard, row - 2, col + 1) && chessBoard[row - 2, col + 1] == 'K')
                            {
                                currAttack++;
                            }
                            //leftUp, leftDown
                            if (IsValid(chessBoard, row - 1, col - 2) && chessBoard[row - 1, col - 2] == 'K')
                            {
                                currAttack++;
                            }
                            if (IsValid(chessBoard, row + 1, col - 2) && chessBoard[row + 1, col - 2] == 'K')
                            {
                                currAttack++;
                            }
                            //downLeft, downRight
                            if (IsValid(chessBoard, row + 2, col - 1) && chessBoard[row + 1, col - 1] == 'K')
                            {
                                currAttack++;
                            }
                            if (IsValid(chessBoard, row + 2, col + 1) && chessBoard[row + 2, col + 1] == 'K')
                            {
                                currAttack++;
                            }
                            //rightUp, rightDown
                            if (IsValid(chessBoard, row + 1, col + 2) && chessBoard[row + 1, col + 2] == 'K')
                            {
                                currAttack++;
                            }
                            if (IsValid(chessBoard, row - 1, col + 2) && chessBoard[row - 1, col + 2] == 'K')
                            {
                                currAttack++;
                            }
                            if (currAttack > maxAttack)
                            {
                                maxAttack = currAttack;
                                rows = row;
                                cols = col;
                            }
                        }
                    }
                }
                if (maxAttack > 0)
                {
                    attackedKnights++;
                    chessBoard[rows, cols] = '0';
                }
                else
                {
                    Console.WriteLine(attackedKnights); 
                    break;
                }

            }
        }

        private static bool IsValid(char[,] chessBoard, int row, int col)
        {
            return row >= 0 && row < chessBoard.GetLength(0) && col >= 0 && col < chessBoard.GetLength(1);
        }

        private static char[,] ReadBoard(int rows, int cols)
        {
            char[,] chessBoard = new char[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < cols; col++)
                {
                    chessBoard[row, col] = input[col];
                }
            }
            return chessBoard;
        }
    }
}
