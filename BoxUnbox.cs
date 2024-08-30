using System;
class BoxUnbox
{
public static void Main()
{
int a=10,b;
Object o;
o=a;//boxing
Console.WriteLine(o);
b=(int)o;//unboxing
Console.WriteLine(b);
}
}