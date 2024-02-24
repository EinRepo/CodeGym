using System;


namespace MineSweeper
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] map = {
            {"*", ".", ".", "."},
            {".", ".", ".", "."},
            {".", "*", ".", "."},
            {".", ".", ".", "."}
        };
            int MAP_HEIGHT = map.GetLength(0);
            int MAP_WIDTH = map.GetLength(1);

            string[,] mapReport = new string[MAP_HEIGHT, MAP_WIDTH];
            for (int yCordinate = 0; yCordinate < MAP_HEIGHT; yCordinate++)
            {
                for (int xCordinate = 0; xCordinate < map.GetLength(0); xCordinate++)
                {
                    string curentCell = map[yCordinate, xCordinate];
                    if (curentCell.Equals("*"))
                    {
                        mapReport[yCordinate, xCordinate] = "*";
                    }
                    else
                    {
                        int[,] NEIGHBOURS_Cordinate = {
                        {yCordinate - 1, xCordinate - 1}, {yCordinate - 1, xCordinate}, {yCordinate - 1, xCordinate + 1},
                        {yCordinate, xCordinate - 1}, {yCordinate, xCordinate + 1},
                        {yCordinate + 1, xCordinate - 1}, {yCordinate + 1, xCordinate}, {yCordinate + 1, xCordinate + 1},};

                        int minesAround = 0;
                        int length = NEIGHBOURS_Cordinate.GetLength(0);
                        for (int i = 0; i < length; i++)
                        {
                            int xCordinateOfNeighbour = NEIGHBOURS_Cordinate[i, 1];
                            int yCordinateOfNeighbour = NEIGHBOURS_Cordinate[i, 0];

                            bool isOutOfMapNeighbour = xCordinateOfNeighbour < 0
                                    || xCordinateOfNeighbour == MAP_WIDTH
                                    || yCordinateOfNeighbour < 0
                                    || yCordinateOfNeighbour == MAP_HEIGHT;
                            if (isOutOfMapNeighbour)
                            {
                                continue;
                            }

                            bool isMineOwnerNeighbour = map[yCordinateOfNeighbour, xCordinateOfNeighbour].Equals("*");
                            if (isMineOwnerNeighbour)
                            {
                                minesAround++;
                            }
                        }

                        mapReport[yCordinate, xCordinate] = minesAround.ToString();
                    }
                }
            }

            for (int yCordinate = 0; yCordinate < MAP_HEIGHT; yCordinate++)
            {
                Console.WriteLine("\n");
                for (int xCordinate = 0; xCordinate < MAP_WIDTH; xCordinate++)
                {
                    String currentCellReport = mapReport[yCordinate, xCordinate];
                    Console.Write(currentCellReport);
                }
            }
            Console.ReadLine();
        }
    }
}