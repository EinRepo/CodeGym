using System;
using System.Threading;

namespace ConsoleSnakeGame
{
    class Program
    {
        static int width = 20;
        static int height = 10;
        static int snakeX, snakeY;
        static int fruitX, fruitY;
        static int score;
        static bool gameOver;
        static Direction direction;

        static int[] tailX = new int[100];
        static int[] tailY = new int[100];
        static int tailLength;

        enum Direction
        {
            None,
            Up,
            Down,
            Left,
            Right
        }

        static void Main(string[] args)
        {
            Console.SetWindowSize(width + 3, height + 4); //make the console size fit the playing field
            Console.SetBufferSize(width + 3, height + 4);
            Console.CursorVisible = true;
            SetupGame();
            

            while (!gameOver)
            {
                Draw();
                Input();
                Logic();
                Thread.Sleep(100);
            }

            Console.CursorVisible = true;
        }

        static void SetupGame()
        {
            Random random = new Random();
            snakeX = width / 2;
            snakeY = height / 2;
            fruitX = random.Next(0, width);
            fruitY = random.Next(0, height);
            score = 0;
            tailLength = 0;
            direction = Direction.None;
            gameOver = false;
        }

        static void Draw()
        {
            Console.Clear();

            for (int i = 0; i < width + 2; i++)
                Console.Write("#");
            Console.WriteLine();

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (x == 0)
                        Console.Write("#");

                    if (x == snakeX && y == snakeY)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("O");
                        Console.ResetColor();
                    }
                    else if (x == fruitX && y == fruitY)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("F");
                        Console.ResetColor();
                    }
                    else
                    {
                        bool isTail = false;
                        for (int t = 0; t < tailLength; t++)
                        {
                            if (tailX[t] == x && tailY[t] == y)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow; // Set body color
                                Console.Write("o");
                                Console.ResetColor();
                                isTail = true;
                                break;
                            }
                        }

                        if (!isTail)
                            Console.Write(" ");
                    }

                    if (x == width - 1)
                        Console.Write("#");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < width + 2; i++)
                Console.Write("#");
            Console.WriteLine();

            Console.SetCursorPosition(0, height + 2);
            Console.WriteLine("Score: " + score);
        }

        static void Input()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (direction != Direction.Down)
                            direction = Direction.Up;
                        break;
                    case ConsoleKey.DownArrow:
                        if (direction != Direction.Up)
                            direction = Direction.Down;
                        break;
                    case ConsoleKey.LeftArrow:
                        if (direction != Direction.Right)
                            direction = Direction.Left;
                        break;
                    case ConsoleKey.RightArrow:
                        if (direction != Direction.Left)
                            direction = Direction.Right;
                        break;
                    case ConsoleKey.Escape:
                        gameOver = true;
                        break;
                }
            }
        }

        static void Logic()
        {
            int prevX = tailX[0];
            int prevY = tailY[0];
            int prev2X, prev2Y;
            tailX[0] = snakeX;
            tailY[0] = snakeY;

            for (int i = 1; i < tailLength; i++)
            {
                prev2X = tailX[i];
                prev2Y = tailY[i];
                tailX[i] = prevX;
                tailY[i] = prevY;
                prevX = prev2X;
                prevY = prev2Y;
            }

            switch (direction)
            {
                case Direction.Up:
                    snakeY--;
                    break;
                case Direction.Down:
                    snakeY++;
                    break;
                case Direction.Left:
                    snakeX--;
                    break;
                case Direction.Right:
                    snakeX++;
                    break;
            }

            if (snakeX < 0 || snakeX >= width || snakeY < 0 || snakeY >= height)
                gameOver = true;

            for (int i = 0; i < tailLength; i++)
            {
                if (tailX[i] == snakeX && tailY[i] == snakeY)
                    gameOver = true;
            }

            if (snakeX == fruitX && snakeY == fruitY)
            {
                Random random = new Random();
                score += 10;
                fruitX = random.Next(0, width);
                fruitY = random.Next(0, height);
                tailLength++;
            }
        }
    }
}