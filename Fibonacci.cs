using System;
class Fibonacci
{
public static void Main()
{
Console.WriteLine("Enter a range number");
int num=Convert.ToInt32(Console.ReadLine());
int num1=0,num2=1;
for(int i=1;i<=num;i++)
{
	Console.Write(num1+" ");
	int num3=num1+num2;
	num1=num2;
	num2=num3;
}
}
}