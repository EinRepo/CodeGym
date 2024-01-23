// See https://aka.ms/new-console-template for more information

double height;
double weight;

Console.WriteLine("Please enter your height in meters:");
height = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Please enter your weight in kilograms:");
weight = double.Parse(Console.ReadLine() ?? "0");

double bmi = weight / Math.Pow(height, 2);
bmi = Math.Round(bmi, 1);


Console.Write("BMI: " + bmi);

if (bmi < 18)
    Console.WriteLine(" Underweight");
else if (bmi < 25.0)
    Console.WriteLine(" Normal");
else if (bmi < 30.0)
    Console.WriteLine(" Overweight");
else
    Console.WriteLine(" Obese");