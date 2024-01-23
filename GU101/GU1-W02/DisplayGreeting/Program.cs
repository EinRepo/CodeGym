// See https://aka.ms/new-console-template for more information


Console.WriteLine("Enter your name: ");

string yourName = Console.ReadLine() ?? "friend";
//vscode warning yourName co the la null nen phai them ??

Console.WriteLine("Hello: " + yourName);
