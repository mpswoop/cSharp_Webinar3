// input number N, output table of cubes from 1 to N
Console.Clear();
Console.WriteLine("Please input a number");

int num1 = Convert.ToInt32(Console.ReadLine());
num1 = Math.Abs(num1);

int i = 1;

Console.WriteLine(""); 

if (num1 == 0)
{
    Console.WriteLine("input 0 is not valid");
    
}

else 

Console.WriteLine("row of squares between 1 and input"); 

while (i <= num1)
{
    Console.WriteLine(Math.Pow(i,3));
    i++;
}