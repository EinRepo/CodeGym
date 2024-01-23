// See https://aka.ms/new-console-template for more information

double rate = 23000;

Console.Write("Enter the amount of USD: ");
double usd = Convert.ToDouble(Console.ReadLine());
double vnd = usd * rate;
Console.WriteLine("Conversion rate is " + rate + " VND to 1 USD");
Console.WriteLine("Equivalence in VND: " + vnd);
