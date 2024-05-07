namespace TicTacToe
{
    public abstract class Player
    {
        public string Name { get; set; }
        public char Symbol { get; set; }

        public abstract void MakeMove(Board board);
    }
}
