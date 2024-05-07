using System;

namespace TicTacToe
{
    public class Board
    {
        private char[,] _cells;

        public Board()
        {
            _cells = new char[3, 3];
            InitializeBoard();
        }

        private void InitializeBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    _cells[i, j] = '-';
                }
            }
        }

        public void DrawBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{_cells[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public bool IsBoardFull()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (_cells[i, j] == '-')
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool IsCellEmpty(int row, int col)
        {
            return _cells[row, col] == '-';
        }

        public void PlaceMove(int row, int col, char symbol)
        {
            _cells[row, col] = symbol;
        }

        public bool CheckWin(char symbol)
        {
            // Kiểm tra hàng ngang
            for (int i = 0; i < 3; i++)
            {
                if (_cells[i, 0] == symbol && _cells[i, 1] == symbol && _cells[i, 2] == symbol)
                {
                    return true;
                }
            }

            // Kiểm tra hàng dọc
            for (int j = 0; j < 3; j++)
            {
                if (_cells[0, j] == symbol && _cells[1, j] == symbol && _cells[2, j] == symbol)
                {
                    return true;
                }
            }

            // Kiểm tra đường chéo chính (\)
            if (_cells[0, 0] == symbol && _cells[1, 1] == symbol && _cells[2, 2] == symbol)
            {
                return true;
            }

            // Kiểm tra đường chéo phụ (/)
            if (_cells[0, 2] == symbol && _cells[1, 1] == symbol && _cells[2, 0] == symbol)
            {
                return true;
            }

            return false;
        }
    }
}
