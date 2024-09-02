using System;
class ReverseNumber
{
	public static void Main()
	{
		Console.Write("Enter a number: ");
		int num=Convert.ToInt32(Console.ReadLine());
		int rev=0;
		while(num!=0)
		{
			int d=num%10;
			rev=(rev*10)+d;
			num=num/10;
		}
		Console.WriteLine(rev);
	}
}