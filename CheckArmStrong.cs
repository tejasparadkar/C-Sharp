using System;
class CheckArmStrong
{
	static int num,d,temp,sum,c;
	public static void Input()
	{
		Console.WriteLine("Enter a number: ");
		num=Convert.ToInt32(Console.ReadLine());
	}
	public static void Check()
	{
		temp=num;
		while(num!=0)
		{
			d=num%10;
			c=d*d*d;
			sum=sum+c;
			num=num/10;
			c=0;
		}
		if(sum==temp)
		{
			Console.WriteLine("Armstrong");
		}
		else
		{
			Console.WriteLine("Not Armstrong");
		}
	}
	public static void Main()
	{
		Input();
		Check();
	}
}