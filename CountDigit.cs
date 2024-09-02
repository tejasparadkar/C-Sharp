using System;
class CountDigit
{
public static void Main()
{
int num=1222000;
int count=0;
while(num!=0)
{
num=num/10;
count=count+1;
}
Console.WriteLine(count);
}
}
