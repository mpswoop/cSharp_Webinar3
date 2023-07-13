// input two 3D of coordinates X & Y & Z both and calculate distance

Console.Clear();

Console.WriteLine("input first X coordinate");
double firstX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input first Y coordinate");
double firstY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input first Z coordinate");
double firstZ = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input second X coordinate");
double secondX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input second Y coordinate");
double secondY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input second Z coordinate");
double secondZ = Convert.ToInt32(Console.ReadLine());

double distanceX = Math.Abs(firstX - secondX);
double distanceY = Math.Abs(firstY - secondY);
double distanceZ = Math.Abs(firstZ - secondZ);


Console.WriteLine("");

Console.WriteLine(distanceX);
Console.WriteLine(distanceY);
Console.WriteLine(distanceZ);
Console.WriteLine("");
double distance = Math.Sqrt(distanceX * distanceX + distanceY * distanceY + distanceZ * distanceZ);

Console.WriteLine("The distance between the coordinates is:");
Console.WriteLine($"{Math.Round(distance,2)}");

