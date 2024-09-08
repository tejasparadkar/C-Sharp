using System;
class PrintArmStrong
{
	static int num,d,c,sum,temp,n;
	public static void Input()
	{
		Console.Write("Enter a range: ");
		num=Convert.ToInt32(Console.ReadLine());
	}
	public static void Print()
	{		
		for(int i=1;i<=num;i++)
		{
			n=i;
			temp=i;
			while(n!=0)
			{
				d=n%10;
				c=d*d*d;
				sum=sum+c;
				n=n/10;
				c=0;
			}
			if(sum==temp)
			{
				Console.WriteLine(i+" ");
				sum=0;
			}
			else
			{
				sum=0;
			}
		}
	}
	public static void Main()
	{
		Input();
		Print();
	}
}