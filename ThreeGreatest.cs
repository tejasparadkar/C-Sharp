using System;
class ThreeGreatest
{
public static void Main()
{
int a=10,b=20,c=30;
if(a>b && a>c)
{
Console.WriteLine("{0} is greatest",a);
}
else if(b>c)
{
Console.WriteLine("{0} is greatest",b);
}
else
{
Console.WriteLine("{0} is greatest",c);
}
}
}