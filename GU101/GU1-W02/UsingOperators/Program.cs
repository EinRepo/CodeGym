// See https://aka.ms/new-console-template for more information

float width;
float height;

Console.Write("Enter width: ");
width = float.Parse(Console.ReadLine() ?? "0.0");
Console.Write("Enter height: ");
height = float.Parse(Console.ReadLine() ?? "0.0");

float area = width * height;
Console.WriteLine("Area is: " + area);