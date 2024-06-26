﻿using System;
using System.Threading;

class Program
{
    static int screenWidth = 20;
    static int screenHeight = 10;
    static char snakeHeadSymbol = 'O';
    static char snakeBodySymbol = '■';
    static char foodSymbol = '@';
    static char wallSymbol = '#';

    static int[] snakeX;
    static int[] snakeY;
    static int snakeLength;
    static int foodX;
    static int foodY;
    static ConsoleKeyInfo keyInfo;
    static ConsoleKey currentDirection;
    static int score = 0;   
    static bool gameover;

    static void Main(string[] args)
    {
        Console.CursorVisible = false;
        Console.SetWindowSize(screenWidth, screenHeight + 3);
        Console.SetBufferSize(screenWidth, screenHeight + 3);
        Console.ForegroundColor = ConsoleColor.Green;

        InitializeGame();

        while (!gameover)
        {
            if (Console.KeyAvailable)
            {
                keyInfo = Console.ReadKey(true);
                currentDirection = keyInfo.Key;
            }

            CheckCollision();
            if (!gameover)
            {
                MoveSnake();
            }           
            DrawScreen();

            Thread.Sleep(250);
        }

        Console.SetCursorPosition(0, screenHeight + 1);
        Console.WriteLine("Game Over. Press any key to exit...");
        Console.ReadKey();
    }

    static void InitializeGame()
    {
        int maxSnakeLength = (screenWidth - 2) * (screenHeight - 2);
        snakeX = new int[maxSnakeLength];
        snakeY = new int[maxSnakeLength];
        snakeLength = 1;
        snakeX[0] = screenWidth / 2;
        snakeY[0] = screenHeight / 2;
        currentDirection = ConsoleKey.RightArrow;
        gameover = false;

        GenerateFood();
    }

    static void GenerateFood()
    {
        Random random = new Random();
        bool validPosition = false;

        while (!validPosition)
        {
            foodX = random.Next(1, screenWidth - 1);
            foodY = random.Next(1, screenHeight - 1);

            validPosition = true;

            for (int i = 0; i < snakeLength; i++)
            {
                if (snakeX[i] == foodX && snakeY[i] == foodY)
                {
                    validPosition = false;
                    break;
                }
            }
        }
    }

    static void MoveSnake()
    {
        int snakeHeadX = snakeX[0];
        int snakeHeadY = snakeY[0];

        switch (currentDirection)
        {
            case ConsoleKey.UpArrow:
                snakeHeadY--;
                break;
            case ConsoleKey.DownArrow:
                snakeHeadY++;
                break;
            case ConsoleKey.LeftArrow:
                snakeHeadX--;
                break;
            case ConsoleKey.RightArrow:
                snakeHeadX++;
                break;
        }

        for (int i = snakeLength - 1; i > 0; i--)
        {
            snakeX[i] = snakeX[i - 1];
            snakeY[i] = snakeY[i - 1];
        }

        snakeX[0] = snakeHeadX;
        snakeY[0] = snakeHeadY;
    }

    static void CheckCollision()
    {
        if (snakeX[0] == foodX && snakeY[0] == foodY)
        {
            snakeLength++;
            score += 10;
            GenerateFood();
        }

        if (snakeX[0] == 0 || snakeX[0] == screenWidth - 1 || snakeY[0] == 0 || snakeY[0] == screenHeight - 1)
        {
            gameover = true;
        }

        for (int i = 1; i < snakeLength; i++)
        {
            if (snakeX[0] == snakeX[i] && snakeY[0] == snakeY[i])
            {
                gameover = true;
                break;
            }
        }
    }

    static void DrawScreen()
    {
        Console.Clear();

        for (int i = 0; i < screenWidth; i++)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(i, 0);
            Console.Write(wallSymbol);
            Console.SetCursorPosition(i, screenHeight - 1);
            Console.Write(wallSymbol);
        }

        for (int i = 1; i < screenHeight - 1; i++)
        {
            Console.SetCursorPosition(0, i);
            Console.Write(wallSymbol);
            Console.SetCursorPosition(screenWidth - 1, i);
            Console.Write(wallSymbol);
        }

        Console.SetCursorPosition(foodX, foodY);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(foodSymbol);

        Console.SetCursorPosition(snakeX[0], snakeY[0]);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(snakeHeadSymbol);

        for (int i = 1; i < snakeLength; i++)
        {
            Console.SetCursorPosition(snakeX[i], snakeY[i]);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(snakeBodySymbol);
        }

        //scores
        Console.SetCursorPosition(0, screenHeight);
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("SCORE: " + score);

    }
}