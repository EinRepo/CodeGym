// See https://aka.ms/new-console-template for more information

Console.WriteLine("Linear Equation Solver");
Console.WriteLine("Given the equation 'ax + b = 0', please enter constants:");

Console.Write("a: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("b: ");
double b = Convert.ToDouble(Console.ReadLine());

if (a != 0)
{
    double solution = -b / a;
    Console.Write("The solution is: " + solution);
}
else
{
    if (b == 0)
    {
        Console.Write("All numbers can be represented as x");
    }
    else
    {
        Console.Write("No solution sastifies");
    }
}