// input two pairs of coordinates X & Y both and calculate distance

Console.WriteLine("input first X coordinate");
double firstX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input first Y coordinate");
double firstY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input second X coordinate");
double secondX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input second Y coordinate");
double secondY = Convert.ToInt32(Console.ReadLine());

double distanceX = Math.Abs(firstX - secondX);
double distanceY = Math.Abs(firstY - secondY);


Console.WriteLine("");

Console.WriteLine(distanceX);
Console.WriteLine(distanceY);
Console.WriteLine("");
Console.WriteLine("The distance between the coordinates is:");
Console.WriteLine(Math.Sqrt(distanceX * distanceX + distanceY * distanceY));

