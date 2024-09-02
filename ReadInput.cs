using System;
class ReadInput
{
public static void Main()
{
Console.WriteLine("Enter a number: ");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter a number: ");
int b=Convert.ToInt32(Console.ReadLine());
int c=a+b;
Console.WriteLine("Sum is {0}",c);
}
}