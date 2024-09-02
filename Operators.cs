using System;
class Operators
{
public static void Main()
{
int a=5,b;
b=a++;//post increment
Console.WriteLine("a={0} and b={1}",a,b);
b=++a;//pre increment
Console.WriteLine("a={0} and b={1}",a,b);
b=a--;//post decrement
Console.WriteLine("a={0} and b={1}",a,b);
b=--a;//pre decrement
Console.WriteLine("a={0} and b={1}",a,b);
}
}