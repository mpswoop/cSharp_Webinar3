// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please input your square");
int square = Convert.ToInt32(Console.ReadLine());
if (square == 1) Console.WriteLine("X > 0; Y > 0");
else if (square == 2) Console.WriteLine("X < 0; Y > 0");
else if (square == 3) Console.WriteLine("X < 0; Y < 0");
else if (square == 4) Console.WriteLine("X > 0; Y < 0");
else Console.WriteLine("input error");