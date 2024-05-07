using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace TicTacToe
{
    public class Game
    {
        private Board _board;
        private Player _player1;
        private Player _player2;
        

        public Game()
        {
            _board = new Board();
            _player1 = new HumanPlayer { Name = "Player 1", Symbol = 'X' };
            _player2 = new ComputerPlayer { Name = "Computer", Symbol = 'O' };
            GameResult.Load();

        }




        public void Start()
        {
            Console.WriteLine("Welcome to TicTacToe!");
            ShowStats();
            while (true)
            {
                _board.DrawBoard();

                _player1.MakeMove(_board);
                if (_board.CheckWin(_player1.Symbol))
                {
                    Console.WriteLine($"{_player1.Name} wins!");
                    GameResult.Player1Wins++;
                    break;
                }
                else if (_board.IsBoardFull())
                {
                    Console.WriteLine("It's a draw!");
                    break;
                }
                
                _board.DrawBoard();
                Console.WriteLine($"{_player2.Name}'s turn...");
                Thread.Sleep(500);

                _player2.MakeMove(_board);
                if (_board.CheckWin(_player2.Symbol))
                {
                    _board.DrawBoard();
                    Console.WriteLine($"{_player2.Name} wins!");
                    GameResult.Player2Wins++;
                    break;
                }
                else if (_board.IsBoardFull())
                {
                    _board.DrawBoard();
                    Console.WriteLine("It's a draw!");
                    break;
                }
            }

            //Save and show stats
            GameResult.NumberOfGames++;
            GameResult.Save();
            ShowStats();
            Console.WriteLine("Thanks for playing! I'm proud of this one");
            
        }

        public void ShowStats()
        {
            Console.WriteLine("Player 1 wins: " + GameResult.Player1Wins);
            Console.WriteLine("Player 2 wins: " + GameResult.Player2Wins);
            Console.WriteLine("Total number of games played: " + GameResult.NumberOfGames);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Start();

            Console.ReadKey();
        }
    }
}
