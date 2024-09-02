using System;
class SumOfDigits
{
	public static void Main()
	{
		Console.Write("Enter a number: ");	
		int num=Convert.ToInt32(Console.ReadLine());
		int sum=0;
		while(num!=0)
		{
			int d=num%10;
			sum=sum+d;
			num=num/10;
		}
		Console.WriteLine(sum);
	}
}