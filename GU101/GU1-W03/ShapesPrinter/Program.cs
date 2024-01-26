using System;

namespace ShapesPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = -1;
            while (choice != 0)
            {
                Console.WriteLine("1.Print a rectangle");
                Console.WriteLine("2.Print a square triangle");
                Console.WriteLine("3.Print a isosceles triangle");
                Console.WriteLine("0.Exit");
                Console.Write("Your choice: ");
                choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    //Print rectangle
                    Console.WriteLine("Please enter a height");
                    int height = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter a width");
                    int width = int.Parse(Console.ReadLine());
                    Console.Write("\n");
                    for (int i = 1; i <= height; i++)
                    {
                        for (int j = 1; j <= width; j++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine("");
                    }
                    Console.Write("\n");
                }

                else if (choice == 2)
                {
                    //Print square rectangle
                    Console.WriteLine("Please enter a height");
                    int height = int.Parse(Console.ReadLine());
                    Console.WriteLine("Where do you want the square conrner to be?");
                    Console.WriteLine("1.Top-left");
                    Console.WriteLine("2.Top-right");
                    Console.WriteLine("3.Bottom-left");
                    Console.WriteLine("4.Bottom-right");
                    int sqCorner = int.Parse(Console.ReadLine());
                    Console.Write("\n");
                    if (sqCorner == 1)
                    {
                        for (int i = 0; i < height; i++)
                        {
                            for (int j = 0; j < height - i; j++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine("");
                        }
                        Console.Write("\n");
                    }

                    else if (sqCorner == 2)
                    {
                        for (int i = 0; i < height; i++)
                        {
                            for (int j = 0; j < i; j++)
                            {
                                Console.Write("  ");
                            }
                            for (int j = 0; j < height - i; j++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine("");
                        }
                        Console.Write("\n");
                    }

                    else if (sqCorner == 3)
                    {
                        for (int i = 0; i < height; i++)
                        {
                            for (int j = 0; j < i + 1; j++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine("");
                        }
                        Console.Write("\n");
                    }

                    else if (sqCorner == 4)
                    {
                        for (int i = 0; i < height; i++)
                        {
                            for (int j = 0; j < height - i - 1; j++)
                            {
                                Console.Write("  ");
                            }
                            for (int j = 0; j < i + 1; j++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine("");
                        }
                        Console.Write("\n");
                    }
                }

                else if (choice == 3)
                {
                    //Draw an isoceles triangle
                    Console.WriteLine("Please enter a height");
                    int height = int.Parse(Console.ReadLine());
                    Console.Write("\n");
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < height - i - 1; j++)
                        {
                            Console.Write(" ");
                        }
                        for (int j = 0; j < i * 2 + 1; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine("");
                    }
                    Console.Write("\n");
                }




            }
        }
    }
}

