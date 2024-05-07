using System;

namespace TicTacToe
{
    public class HumanPlayer : Player
    {
        public override void MakeMove(Board board)
        {
            Console.Write($"It's {Name}'s turn. Enter your move (row column - no spaces):\nMy move: ");
            string input = Console.ReadLine();

            if (input.Length == 2 && int.TryParse(input[0].ToString(), out int row) && int.TryParse(input[1].ToString(), out int col))
            {
                if (row >= 1 && row < 4 && col >= 1 && col < 4 && board.IsCellEmpty(row - 1, col - 1))
                {
                    board.PlaceMove(row - 1, col - 1, Symbol);
                }
                else
                {
                    Console.WriteLine("Invalid move! Try again.\n");
                    MakeMove(board);
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Input should consist of 2 digits. Try again.\n");
                MakeMove(board);
            }
        }
    }
}
