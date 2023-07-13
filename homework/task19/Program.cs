// check 5 digit figure - palindrome yes or no
Console.WriteLine("Please input a 5 digit number");

int num1 = Convert.ToInt32(Console.ReadLine());
int length = num1.ToString().Length;

if (length != 5)
{
    Console.WriteLine("wrong input, need 5 digits");
}

// int digit1 = num1 /= 10000;
// int digit2 = num1 - (digit1*10000);
int digit5 = num1 % 10;
int digit4 = num1 / 10 % 10;
int digit3 = num1 / 100 % 10;
int digit2 = num1 / 1000 % 10;
int digit1 = num1 / 10000 % 10;


// Console.WriteLine(digit1);
// Console.WriteLine(digit2);
// Console.WriteLine(digit3);
// Console.WriteLine(digit4);
// Console.WriteLine(digit5);

if (digit1 == digit5 && digit2 == digit4)
{
    Console.WriteLine("yes, this is a palindrome");
}

else
{
    Console.WriteLine("no, this is not a palindrome");
}