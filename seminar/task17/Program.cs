// input coordinates X & Y both != 0 and show sqare of coordinates to be demonstrated
Console.WriteLine("input X coordinate");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input Y coordinate");
int y = Convert.ToInt32(Console.ReadLine());

if (x == 0 || y == 0) 
{
    Console.WriteLine("Input 0 not accepted");
}

// else if (y == 0)
// {
//     Console.WriteLine("Input 0 not accepted");
// }

else

    if (x > 1 && y > 1)
    {
        Console.WriteLine("your dot is in square 1");
    }

    else if (x < 0 && y > 0)
    {
        Console.WriteLine("your dot is in square 2");
    }

    else if (x < 0 && y < 0)
    {
        Console.WriteLine("your dot is in square 3");
    }

    else if (x > 0 && y < 0)
    {
        Console.WriteLine("your dot is in square 4");
    }