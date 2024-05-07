using System;
using System.IO;

namespace TicTacToe
{
    public static class GameResult
    {
        public static int NumberOfGames { get; set; }
        public static int Player1Wins { get; set; }
        public static int Player2Wins { get; set; }

        public static void Load()
        {
            if (File.Exists("gameResult.txt"))
            {
                string[] lines = File.ReadAllLines("gameResult.txt");

                if (lines.Length == 3 && int.TryParse(lines[0], out int numberOfGames) && int.TryParse(lines[1], out int player1Wins) && int.TryParse(lines[2], out int player2Wins))
                {
                    NumberOfGames = numberOfGames;
                    Player1Wins = player1Wins;
                    Player2Wins = player2Wins;
                }
            }
        }

        public static void Save()
        {    

            string[] lines = {
            NumberOfGames.ToString(),
            Player1Wins.ToString(),
            Player2Wins.ToString()
        };

            File.WriteAllLines("gameResult.txt", lines);
        }

    }
}
