using System;
class CheckPrime
{
	public static void Main()
	{
		Console.WriteLine("Enter a number: ");
		int num=Convert.ToInt32(Console.ReadLine());
		int count=2;
		if(num==0 || num==1)
		{
			count++;
		}
		for(int i=2;i<=num/2;i++)
		{
			if(num%i==0)
			{
				count++;
			}
		}
		if(count==2)
		{
			Console.WriteLine("Prime");
		}
		else
		{
			Console.WriteLine("Not Prime");
		}
	}
}