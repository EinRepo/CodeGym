using System;

namespace TicTacToe
{
    public class ComputerPlayer : Player
    {
        public override void MakeMove(Board board)
        {
            
            Random random = new Random();
            int row = random.Next(0, 3);
            int col = random.Next(0, 3);

            while (!board.IsCellEmpty(row, col))
            {
                row = random.Next(0, 3);
                col = random.Next(0, 3);
            }

            board.PlaceMove(row, col, Symbol);
        }
    }
}
